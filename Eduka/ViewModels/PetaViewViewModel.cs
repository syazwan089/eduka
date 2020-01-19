using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Eduka.ViewModels
{
    public class PetaViewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string imageUrl;

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ImageUrl"));
            }
        }


        public PetaViewViewModel(string imageUrl)
        {
            ImageUrl = imageUrl;
        }
    }
}
