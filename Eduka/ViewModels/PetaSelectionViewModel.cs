using Eduka.Views.Peta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class PetaSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Command goToCommand { get; set; }
        public PetaSelectionViewModel()
        {
            goToCommand = new Command(gotoPage);
        }

        private void gotoPage(object obj)
        {
            string page = obj.ToString();
            PetaMenuPage Peta = new PetaMenuPage();
            Peta.BindingContext = new PetaMenuViewModel(page);

            App.Current.MainPage.Navigation.PushAsync(Peta);

        }
    }
}
