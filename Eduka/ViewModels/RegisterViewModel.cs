using Eduka.Models;
using Eduka.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command RegisterCommand { get; set; }
        public IAuth _rest => DependencyService.Get<IAuth>();

        private User user;

        public User users
        {
            get { return user; }
            set { user = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("users"));
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }

        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
            }
        }


        public RegisterViewModel()
        {
            users = new User();
            RegisterCommand = new Command(send);
        }

        private async void send()
        {
            IsRunning = true;
            if (users != null && Password != null || Password != "")
            {
                var result = await _rest.Register(users.student_name,Password,users.student_class);

                if(result != null)
                {
                   await App.Current.MainPage.DisplayAlert("Pendaftaran Berjaya", $"Sila log masuk dengan id {result}", "Okay", "cancel");
                }

            }

            else
            {
                await App.Current.MainPage.DisplayAlert("Ralat", "Pendaftaran tidak berjaya", "Tutup");
            }
            IsRunning = false;
        }
    }
}
