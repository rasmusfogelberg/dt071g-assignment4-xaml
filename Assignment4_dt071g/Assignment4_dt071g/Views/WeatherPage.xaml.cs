using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment4_dt071g
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            GetWeatherInfo();
        }

        private string lat = "90";
        private string lon = "135";

        private async void GetWeatherInfo()
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid=5f60d4e7075cf769529e697ee76faaa9&units=metric";

            var result = await ApiCaller.Get(url);

            if(result.Success)
            {
                try
                {
                    var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(result.Response);
                    descriptionTxt.Text = weatherInfo.weather[0].description.ToUpper();
                    temperatureTxt.Text = weatherInfo.main.temp.ToString("0");
                    cloudinessTxt.Text = $"{weatherInfo.clouds.all}%";

                }
                catch (Exception ex)
                {
                    await DisplayAlert("Weather Info", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("Weather Info", "No weather information found", "OK");
            }
        }
    }
}