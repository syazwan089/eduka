using Eduka.Models;
using Eduka.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class NewsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IRestApi _rest => DependencyService.Get<IRestApi>();



        private List<News> news;

        public List<News> News
        {
            get { return news; }
            set { news = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("News"));
            }
        }


        public NewsViewModel()
        {
            getNews();
        }

        private async Task getNews()
        {
            var result = await _rest.GetNews();
            News = result;
        }
    }
}
