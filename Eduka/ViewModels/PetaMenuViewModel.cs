using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    class PetaMenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command goToCommand { get; set; }

        public PetaMenuViewModel(string id)
        {
            goToCommand = new Command(gotoPage);
        }

        private void gotoPage(object obj)
        {
            string page = obj.ToString();
        }
    }
}
