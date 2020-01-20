using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eduka.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Logout : ContentPage
    {
        public Logout()
        {
            InitializeComponent();
            LogoutFunc();
        }

        private async void LogoutFunc()
        {
            bool x = await DisplayAlert("Adakah anda pasti?", "Anda boleh log masuk pada bila-bila masa", "Logout", "Cancel");
            if(x)
            {
                Preferences.Remove("userid");
                App.Current.MainPage = new NavigationPage(new StartPage());
            }

            else
            {
                App.Current.MainPage = new AppShell();
            }
        }
    }
}