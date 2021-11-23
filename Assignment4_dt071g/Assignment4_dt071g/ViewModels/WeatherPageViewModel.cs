using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Timers;

namespace Assignment4_dt071g
{
    public class WeatherPageViewModel
    {
        public WeatherPageViewModel()
        {
            ExitCommand = new Command(async () =>
            await Application.Current.MainPage.Navigation.PopAsync());
        }

        public ICommand ExitCommand { get; }
    }
}
