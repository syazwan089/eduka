using Eduka.Views.Games;
using Eduka.Views.Peta;
using Eduka.Views.Quiz;
using Eduka.Views.Unit;
using Eduka.Views.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command UnitCommand { get; set; }
        public Command QuizCommand { get; set; }
        public Command VideoCommand { get; set; }
        public Command GameCommand { get; set; }
        public Command PetaCommand { get; set; }
        public HomeViewModel()
        {
            UnitCommand = new Command(unit);
            QuizCommand = new Command(quiz);
            VideoCommand = new Command(video);
            GameCommand = new Command(game);
            PetaCommand = new Command(peta);
        }

        private void peta()
        {
            App.Current.MainPage.Navigation.PushAsync(new PetaSelectionPage());
        }

        private void game()
        {
            App.Current.MainPage.Navigation.PushAsync(new GameSelectionPage());
        }

        private void video()
        {
            App.Current.MainPage.Navigation.PushAsync(new VideoSelectionPage());
        }

        private void quiz()
        {
            App.Current.MainPage.Navigation.PushAsync(new QuizSelectionPage());
        }

        private void unit()
        {
            App.Current.MainPage.Navigation.PushAsync(new UnitSelectionPage());
        }
    }
}
