/*
 * The first file that is accessed when running the app. Here the NavigationPage() is
 * used to set MainPage to the root page. It also allows for other pages to be used 
 * with PushAsync to push a page on top of the "view stack" or PopAsync to remove
 * from the top of the "view stack".
 *  
 * Author: Rasmus Fogelberg 
 */


using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment4_dt071g
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("16944d"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
    }
}
