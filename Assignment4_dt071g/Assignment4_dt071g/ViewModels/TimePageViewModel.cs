/*
 * A view model for the time page that creates the countdown and sends the information to the 
 * view for time.
 *
 * Author: Rasmus Fogelberg 
 */

using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Timers;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Assignment4_dt071g
{
    public class TimePageViewModel : INotifyPropertyChanged
    {
        // Declaring variables
        private string countDown;
        public DateTime endTime = new DateTime(2021, 12, 24, 0, 0, 0);
        public string cTimer;
        System.Timers.Timer timer;

        public event PropertyChangedEventHandler PropertyChanged;

        public TimePageViewModel()
        {
           StartCountDownTimer();

            // Button to go back or "exit" the view
            ExitCommand = new Command(async () =>
            await Application.Current.MainPage.Navigation.PopAsync());
        }

        // Using PropertyChanged to update the text for the countdown timer
        public string CountDown
        { 
            get => countDown;
            set 
            { 
                if (countDown != value) 
                { 
                    countDown = value; 
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("CountDown"));
                    }
                }
            }
        }

        // Using Timer to start the countdown when the page is accessed
        public void StartCountDownTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += t_Tick;
           
            timer.Start();
        }
       
        // Method that will start the ticking of the timer
        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime - DateTime.Now;

            cTimer = ts.ToString($"d' days,{Environment.NewLine}'h' hours,{Environment.NewLine}'m' minutes,{Environment.NewLine}'s' seconds'");

            MainThread.BeginInvokeOnMainThread(() =>
            {
                // Code to run on the main thread
                CountDown = cTimer;
            });
            if ((ts.TotalMilliseconds < 0) || (ts.TotalMilliseconds < 1000))
            {
                timer.Stop();
            }
        }

        public ICommand ExitCommand { get; }
    }
}
