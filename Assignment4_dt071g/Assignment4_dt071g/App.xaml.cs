using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ConstConfig;

namespace Assignment4_dt071g
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex(Const.SecondaryColor),
                BarTextColor = Color.FromHex(Const.TextColor)
            };
        }
    }
}
