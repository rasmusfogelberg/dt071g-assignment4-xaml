using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace Assignment4_dt071g
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
           TimePageCommand = new Command(async () =>
           await Application.Current.MainPage.Navigation.PushAsync(new TimePage()));

           WeatherPageCommand = new Command(async () =>
            await Application.Current.MainPage.Navigation.PushAsync(new WeatherPage()));
        }


        public Command TimePageCommand { get; }
        public Command WeatherPageCommand { get; }
    }
}
