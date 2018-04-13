using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MergeTestGrund
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Christer : ContentPage
    {
        public Christer()
        {
            InitializeComponent();
        }


        private void Button_OnClicked2(object sender, EventArgs e)
        {
            DisplayAlert("Placeholder", "Denna knapp ska leda till Timmys sida!", "Ok");
        }

        private void Button_OnClicked3(object sender, EventArgs e)
        {
            DisplayAlert("Placeholder", "Denna knapp ska leda till Marcos sida!", "Ok");
        }
    }
}