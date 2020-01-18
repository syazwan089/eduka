using Eduka.Views.Quiz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class QuizSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command goToCommand { get; set; }
        public QuizSelectionViewModel()
        {
            goToCommand = new Command(gotoPage);
        }

        private void gotoPage(object obj)
        {
            string page = obj.ToString();
            QuizMenuPage Quiz = new QuizMenuPage();
            Quiz.BindingContext = new QuizMenuViewModel(page);

            App.Current.MainPage.Navigation.PushAsync(Quiz);
        }
    }
}
