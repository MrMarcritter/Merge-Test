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
	public partial class Marco : ContentPage
	{
		public Marco ()
		{
			InitializeComponent ();
		}


        private async void Button_OnClicked_C(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Christer());
        }

        private async void Button_OnClicked_T(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timmy());
        }
    }
}