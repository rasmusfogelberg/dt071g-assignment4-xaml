/*
 * A view model for the time page that creates the countdown and sends the information to the 
 * view for time.
 * 
 * TODO:
 *  [ ] - Need to make the clock show time remaning in real time (not updating live right now)
 *  [ ] - Look over getters and setters and OOP in general if I'm using the TimeModel correctly
 *  [ ] - Remove the if statments below since they are not needed (or are they for live countdown?)
 *  [ ] - Rename method from "TestCountdown" to something more fitting
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


namespace Assignment4_dt071g
{
    public class TimePageViewModel : INotifyPropertyChanged
    {
        public TimePageViewModel()
        {
            // Button to go back or "exit" the view
            ExitCommand = new Command(async () =>
            await Application.Current.MainPage.Navigation.PopAsync());
        }

        public event PropertyChangedEventHandler PropertyChanged;


        // As I understand how A model should be used. But I don't think I use it
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

        // My attempt to get a live countdown. Much of this code isn't actually used right now
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

        public string Test
        {
            get
            {
                return $"{TestCountdown()}";
            }
        }


        // String name, method Name and function InitTicking are test I used to learn about Xamarin

        string name = "Rasmus";
        public string Name
        {
            get { return name; }
            set { name = value; }
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
