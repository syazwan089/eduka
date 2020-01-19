using Eduka.Models;
using Eduka.Services;
using Eduka.Views.Peta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    class PetaMenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IRestApi _rest => DependencyService.Get<IRestApi>();
        public Command goToCommand { get; set; }

        private List<Peta> petas;

        public List<Peta> LPeta
        {
            get { return petas; }
            set { petas = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LPeta"));
            }
        }


        private Peta SelectedItem;

        public Peta selectedItem
        {
            get { return SelectedItem; }
            set { SelectedItem = value;
            
                if(SelectedItem != null)
                {
                    PetaView page = new PetaView();
                    page.BindingContext = new PetaViewViewModel(SelectedItem.peta_image);
                    App.Current.MainPage.Navigation.PushAsync(page);
                }

            }
        }



        public PetaMenuViewModel(string id)
        {
            goToCommand = new Command(gotoPage);
            getPeta(id);
        }

        private async Task getPeta(string topic_id)
        {
            var result = await _rest.GetPeta(topic_id);
            LPeta = result;
        }

        private void gotoPage(object obj)
        {
            string page = obj.ToString();
        }
    }
}
