using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Assignment4_dt071g
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePage : ContentPage
    {
        public TimePage()
        {
            InitializeComponent();
        }

        //DateTime endTime = new DateTime(2021, 12, 24, 0, 0, 0);
        //public void StartCountDownTimer()
        //{
        //    timer = new System.Timers.Timer();
        //    timer.Interval = 1000;
        //    timer.Elapsed += t_Tick;
        //    TimeSpan ts = endTime - DateTime.Now;
        //    cTimer = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
        //    timer.Start();
        //}
        //string cTimer;
        //System.Timers.Timer timer;
        //void t_Tick(object sender, EventArgs e)
        //{
        //    TimeSpan ts = endTime - DateTime.Now;

        //    cTimer = ts.ToString($"d' days,{Environment.NewLine}'h' hours,{Environment.NewLine}'m' minutes,{Environment.NewLine}'s' seconds'");
        //    MainThread.BeginInvokeOnMainThread(() =>
        //    {
        //        // Code to run on the main thread
        //        mylabel.Text = cTimer;
        //    });
        //    if ((ts.TotalMilliseconds < 0) || (ts.TotalMilliseconds < 1000))
        //    {
        //        timer.Stop();
        //    }
        //}


        //protected override void OnAppearing()
        //{
        //    StartCountDownTimer();
        //}

    }
}

// Coode for this was found at:
// https://docs.microsoft.com/en-us/answers/questions/358240/how-to-use-timer-in-xamarin-forms.html#:~:text=LeonLu%2DMSFT%20answered%20%E2%80%A2%20Apr%2016,%3C/StackLayout%3E