using Eduka.Models;
using Eduka.Services;
using Eduka.Views.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class VideoMenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IRestApi _rest => DependencyService.Get<IRestApi>();
        private List<video> videos;

        public List<video> Videos
        {
            get { return videos; }
            set { videos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Videos"));
            }
        }


        private video selectedItem;

        public video SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value;
            if(SelectedItem != null)
                {
                    VideoPlayer page = new VideoPlayer();
                    page.BindingContext = new VideoPlayerViewModel(SelectedItem.video_url);
                    App.Current.MainPage.Navigation.PushAsync(page);
                }
            }
        }


        public VideoMenuViewModel(string id)
        {
            Get(id);
        }

        private void Get(string id)
        {
            GetVideo(id);
        }

      private async Task GetVideo(string id)
        {

            var result = await _rest.GetVideo(id);
            if(result != null)
            {
                Videos = result;
            }
        }

    }
}
