using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace MindOptimizerWeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string APIkey = "c45d81c66c6c766379d43033cf2461e4";

       private void btnSearch_Click_1(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient() )
            {
                string url =
                    string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=imperial&appid={1}", txtCity.Text, APIkey);
                var json = web.DownloadString(url);
                WeatherClass.Root info = JsonConvert.DeserializeObject<WeatherClass.Root>(json);

                picboxIcon.ImageLocation = "https://openweathermap.org/img/w/" + info.Weather[0].icon + ".png";
                lblConditionResp.Text = info.Weather[0].main;
                lblDetResp.Text = info.Weather[0].description;

                lblRainResp.Text = "*** Flash Flood Warning ***";
                lblWindResp.Text = info.Wind.speed.ToString() + " mph";
                lblTempResp.Text = info.Main.temp.ToString() + " F°";
            }

        }

        
    }
}
