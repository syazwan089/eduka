using Eduka.Models;
using Eduka.Services;
using Eduka.Views.Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    class UnitMenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public IRestApi _rest => DependencyService.Get<IRestApi>();
        public Command goToCommand { get; set; }

        private List<Unit> Units;

        public List<Unit> LUnit
        {
            get { return Units; }
            set
            {
                Units = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LUnit"));
            }
        }


        private Unit SelectedItem;

        public Unit selectedItem
        {
            get { return SelectedItem; }
            set
            {
                SelectedItem = value;

                if (SelectedItem != null)
                {
                    UnitView page = new UnitView();
                    page.BindingContext = new UnitViewViewModel(SelectedItem.image);
                    App.Current.MainPage.Navigation.PushAsync(page);
                }

            }
        }




        public UnitMenuViewModel(string id)
        {
            goToCommand = new Command(gotoPage);
            getUnit(id);
        }

        private async Task getUnit(string topic_id)
        {
            var result = await _rest.GetUnit(topic_id);
            LUnit = result;
        }

        private void gotoPage(object obj)
        {
            string page = obj.ToString();
        }
 
    }
}
