using Eduka.Views.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class VideoSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Command goToCommand { get; set; }
        public VideoSelectionViewModel()
        {
            goToCommand = new Command(gotoPage);
        }

        private void gotoPage(object obj)
        {
            string page = obj.ToString();

            VideoMenuPage view = new VideoMenuPage();
            view.BindingContext = new VideoMenuViewModel(page);
            App.Current.MainPage.Navigation.PushAsync(view);

        }
    }
}
