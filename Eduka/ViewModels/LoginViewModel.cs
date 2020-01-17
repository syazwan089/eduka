using Eduka.Models;
using Eduka.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command LoginCommand { get; set; }
        private User user;

        public User users
        {
            get { return user; }
            set
            {
                user = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("users"));
            }
        }
        public IAuth _rest => DependencyService.Get<IAuth>();

        private string UserId;

        public string userId
        {
            get { return UserId; }
            set { UserId = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("userId")); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password")); }
        }



        private bool IsBtnEnable;

        public bool isBtnEnable
        {
            get { return IsBtnEnable; }
            set { IsBtnEnable = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("isBtnEnable")); }
        }

        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning")); }
        }


        public LoginViewModel()
        {
            users = new User();
             isBtnEnable = new bool();
            IsRunning = new bool();
            isBtnEnable = true;
            IsRunning = false;
            LoginCommand = new Command(funct);
        }

        private async void funct(object obj)
        {
            await login();
        }

        private async Task login()
        {
            var result = await _rest.Login(userId, Password);
            if(result != null)
            {
                users = result;
                Preferences.Set("userid", users.student_id.ToString());
                Application.Current.MainPage = new AppShell();
            }

            else
            {
                await App.Current.MainPage.DisplayAlert("Ralat", "ID atau kata laluan salah", "Okay");
            }
        }
    }
}
