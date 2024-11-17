using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; //lets you use json info

namespace WForecast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //constructor
        }


        private async Task<string> GetWeatherAsync(string location) //func for getting weather info
        {
            string apiKey = "**************************"; //openweather key...need to create secure file or change to enviroment variable 
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={location}&appid={apiKey}&units=imperial";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);
                    string weather = data["weather"][0]["description"].ToString();
                    string temp = data["main"]["temp"].ToString(); 
                    return $"Weather: {weather}, Temperature: {temp}°F"; //changes from C to F
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    return $"Could not fetch weather data {response.StatusCode} - {errorContent}"; //Error Handling
                }
            }
        }
        private async Task<string> GetChatGptResponseAsync(string query)
        {
            string apiKey = "*******************************************************"; //gpt key... need to change to secure file, or enviroment variable
            string url = "https://api.openai.com/v1/chat/completions";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey); //creates token for api request
                var jsonData = new
                {
                    model = "gpt-3.5-turbo",
                    messages = new[]
                    {
                        new { role = "user", content = query } 
                    }
                };

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData); //converts .net objects into json strings
                HttpContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    string resultJson = await response.Content.ReadAsStringAsync();
                    JObject resultData = JObject.Parse(resultJson);
                    string chatResponse = resultData["choices"][0]["message"]["content"].ToString();
                    return chatResponse;
                }
                else
                {
                    
                    string errorContent = await response.Content.ReadAsStringAsync(); 
                    return $"Error fetching ChatGPT response: {response.StatusCode} - {errorContent}"; //temporary error details for troubleshooting
                }
            }
        }

        private async void getWeath_Click(object sender, EventArgs e) //button function for weather results + gpt results
        {
            string location = locEnter.Text; //where you enter text
            string weatherInfo = await GetWeatherAsync(location);
            weathFOR.Text = weatherInfo; //text box for output

            
            string chatResponse = await GetChatGptResponseAsync(weatherInfo); //asking chatgpt about weather
            rtbGPT.Text = chatResponse; //textbox for gpt response
        }
    }
}
