/*
 * View model for the weather page. More code from the WeatherPage.xaml.cs could be put here.
 * I thought it was a good practice to use the .cs file under the xaml file to get familiar
 * with how to write code there as well.
 *  
 * Author: Rasmus Fogelberg 
 */

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
            // Button to go back or "exit" the view
            ExitCommand = new Command(async () =>
            await Application.Current.MainPage.Navigation.PopAsync());
        }

        public ICommand ExitCommand { get; }
    }
}
