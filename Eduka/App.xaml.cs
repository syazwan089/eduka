using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Eduka.Services;
using Eduka.Views;
using Xamarin.Essentials;

namespace Eduka
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<IAuth, Auth>();
            if (!String.IsNullOrEmpty(Preferences.Get("userid", "")))
            {
                MainPage = new AppShell();
            }

            else
            {
                MainPage = new NavigationPage(new StartPage());
            }
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
