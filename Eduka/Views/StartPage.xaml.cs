using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eduka.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : CarouselPage
    {
        string ResourceImg = "Eduka.Assets.Images.";
        public StartPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            var assembly = typeof(StartPage);

            im_1.Source = ImageSource.FromResource(ResourceImg + "micro.png", assembly);
            im_2.Source = ImageSource.FromResource(ResourceImg + "neutron.png", assembly);
            im_3.Source = ImageSource.FromResource(ResourceImg + "uji.png", assembly);

            label_1.Text = "Selamat datang ke aplikasi hebat";
            label_2.Text = "Terdapat pelbagai perkara menarik";
            label_3.Text = "Selamat maju jaya";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}