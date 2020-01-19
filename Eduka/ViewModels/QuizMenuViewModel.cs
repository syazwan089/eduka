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
    class QuizMenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IRestApi _rest => DependencyService.Get<IRestApi>();

        private List<topic> topics;

        public List<topic> Topic
        {
            get { return topics; }
            set { topics = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Topic"));
            }
        }


        public QuizMenuViewModel(string id)
        {
            GetQuiz(id);
        }

        private async Task GetQuiz(string id)
        {
          var  result = await _rest.GetQuiz(id);

            if(result != null)
            {
                Topic = result;
            }
        }

    }
}
