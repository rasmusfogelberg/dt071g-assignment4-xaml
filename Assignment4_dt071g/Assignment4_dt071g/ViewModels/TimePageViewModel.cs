using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Timers;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment4_dt071g
{
    public class TimePageViewModel : INotifyPropertyChanged
    {
        public TimePageViewModel()
        {
            ExitCommand = new Command(async () =>
            await Application.Current.MainPage.Navigation.PopAsync());
         
        }

        public event PropertyChangedEventHandler PropertyChanged;


        TimeModel countdown;
        public TimeModel Countdown
        {

            get => countdown;
            set
            {
                countdown = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Countdown)));
            }
        }

        DateTime current = DateTime.Now;
        public string TestCountdown() { 
        DateTime xmas = new DateTime(2021, 12, 24, 0, 0, 0);
        Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
               if (current != DateTime.Now)
               {
                    current = DateTime.Now;
               }
               return true;
           });
                if (current != DateTime.Now)
                {
                    current = DateTime.Now;
                    TimeSpan timeLeft = xmas - current;
                    string message = $"{timeLeft.Days} days,{Environment.NewLine}{timeLeft.Hours} hours,{Environment.NewLine}{timeLeft.Minutes} minutes,{Environment.NewLine}{timeLeft.Seconds} seconds";
                    return message;
                }
                else
                {
                    string message = "Oppsie. Santas countdown timer doesn't seem to work right now!";
                    return message;
                }
        }

        string name = "Rasmus";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Test
        {
            get
            {
                return $"{TestCountdown()}";
            }
        }

        public void InitTicking() {
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                DateTime current = DateTime.Now;
                return true;
            });
        }



        public ICommand ExitCommand { get; }

        
    }
}
