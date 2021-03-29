using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFun.Pages;

namespace XFun
{
    public partial class App : Application
    {
        public static bool IsAthenticate = false;
        public App()
        {
            InitializeComponent();

            if (IsAthenticate)
                MainPage = new NavigationPage(new MainPage());
            else
                MainPage = new NavigationPage(new LoginEmail());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
