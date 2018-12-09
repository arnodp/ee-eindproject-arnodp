using EEGame.ViewModels;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EEGame.Pages;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EEGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());
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
