using Eduka.Views.Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class UnitSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command goToCommand { get; set; }
        public UnitSelectionViewModel()
        {
            goToCommand = new Command(gotoPage);
        }

        private void gotoPage(object obj)
        {
            string page = obj.ToString();
            UnitMenuPage Unit = new UnitMenuPage();
            Unit.BindingContext = new UnitMenuViewModel(page);

            App.Current.MainPage.Navigation.PushAsync(Unit);
        }
    }
}
