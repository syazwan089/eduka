using Eduka.Views.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    class GameMenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command goToCommand { get; set; }

        public GameMenuViewModel(string id)
        {
            goToCommand = new Command(gotoPage);
        }

        private void gotoPage(object obj)
        {
            string page = obj.ToString();
            GameMenuPage Game = new GameMenuPage();
            Game.BindingContext = new GameMenuViewModel(page);

            App.Current.MainPage.Navigation.PushAsync(Game);
        
        }
    }
}
