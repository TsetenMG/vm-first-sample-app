using System;
using TestNavigationApp.Pages;
using TestNavigationApp.Pages.Base;
using TestNavigationApp.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace TestNavigationApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            IocContainer.SetupContainer();

            MainPage = new StartPage();
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
