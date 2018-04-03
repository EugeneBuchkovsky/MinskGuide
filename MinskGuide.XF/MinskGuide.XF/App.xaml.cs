using LightInject;
using MinskGuide.Core;
using MinskGuide.Core.Services;
using MinskGuide.XF.Pages;
using MinskGuide.XF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MinskGuide.XF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Setup();
            //MainPage = new MinskGuide.XF.MainPage();
            MainPage = new NavigationPage(new DashboardPage());
            //MainPage = new DashboardPage();
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

        private void Setup()
        {
            AppContainer.Instance.Register<INavigationService, NavigationServices>(new PerContainerLifetime());
        }
    }
}
