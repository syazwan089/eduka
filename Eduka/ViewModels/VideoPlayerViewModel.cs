using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Eduka.ViewModels
{
    public class VideoPlayerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string vidUrl;

        public string VidUrl
        {
            get { return vidUrl; }
            set { vidUrl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VidUrl"));
            }
        }

        public VideoPlayerViewModel(string  url)
        {
            VidUrl = url;
        }
    }
}
