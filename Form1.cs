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
using Newtonsoft.Json.Linq;

namespace WForecast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public class Message
        //{
        //    public string role { get; set; }
        //    public string content { get; set; } 
        //}

        private string Forecast(string location)
        {
            string apiKey = "********"; //openweather api
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={location}&appid={apiKey}&units=imperial";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = client.GetStringAsync(url).Result; 
                    JObject data = JObject.Parse(response);
                    string weather = data["weather"][0]["description"].ToString();
                    string temp = data["main"]["temp"].ToString();
                    return $"Weather: {weather}, Temperature: {temp}°F";
                }
                catch
                {
                    return "Could not fetch weather data.";
                }
            }
        }

        //private string GPTResponse(string query)
        //{
        //    string apiKey = "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"; //gpt key
        //    string url = "https://api.openai.com/v1/chat/completions";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

        //        //Dictionary<string, object> jsonData = new Dictionary<string, object>
        //        //{
        //        //    { "model", "gpt-3.5-turbo" },
        //        //    { "messages", new[]
        //        //        {
        //        //            new Dictionary<string, string> { { "role", "user" }, { "content", query } }
        //        //        }
        //        //    }
        //        //};
        //        var jsondata = new
        //        {
        //            model = "gpt-3.5-turbo",
        //            messages = new[]
        //            {
        //                new Message { role = "User", content = query}
        //            }



        //        };
        //        try
        //        {
        //            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(jsondata); //conversion to json string
        //            HttpContent content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json"); //ensures correct format
        //            HttpResponseMessage response = client.PostAsync(url, content).Result;  //sends request
        //            string resultString = response.Content.ReadAsStringAsync().Result; //get api response
        //            JObject result = JObject.Parse(resultString); //parse response 
        //            return result["choices"][0]["message"]["content"].ToString(); //get generated response
        //        }
        //        catch
        //        {
        //            return "Could not fetch ChatGPT response.";
        //        }
        //    }
        //}

        private void getWeath_Click(object sender, EventArgs e)
        {
            
            weathFOR.Text = Forecast(locEnter.Text);

            
            //rtbGPT.Text = GPTResponse(weathFOR.Text);
        }
    }
}
