using First.App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace First.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Page1();
            MainPage = new AppShell();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
