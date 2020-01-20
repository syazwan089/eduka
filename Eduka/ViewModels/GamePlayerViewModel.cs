using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class GamePlayerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string GameUrl;

        public string gameUrl
        {
            get { return GameUrl; }
            set { GameUrl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("gameUrl"));
            }
        }

        public GamePlayerViewModel(string url)
        {
            gameUrl = url;
        }
    }
}
