using Eduka.Models;
using Eduka.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Eduka.ViewModels
{

  
    public class PrestasiViewModel : INotifyPropertyChanged
    {

              public event PropertyChangedEventHandler PropertyChanged;
        public IRestApi _rest => DependencyService.Get<IRestApi>();



        private List<Prestasi> pres;

        public List<Prestasi> Pres
        {
            get { return pres; }
            set
            {
                pres = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pres"));
            }
        }
        public PrestasiViewModel()
        {
            getNews();
        }


        private async Task getNews()
        {
            string id = Preferences.Get("userid", "");
            var result = await _rest.resultPrestasi(id);
            Pres = result;
        }
    }
}
