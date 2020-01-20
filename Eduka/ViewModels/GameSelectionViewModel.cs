using Eduka.Views.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class GameSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Command gotopageCommand { get; set; }
        public GameSelectionViewModel()
        {
            gotopageCommand = new Command(go);
        }

        private void go(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new GameMenuPage());
        }
    }
}
