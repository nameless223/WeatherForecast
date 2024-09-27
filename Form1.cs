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

namespace WForecast
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void getWeath_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;

            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Please enter a location.");
                return;
            }
        }
}
