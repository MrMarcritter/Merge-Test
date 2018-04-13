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
	public partial class Timmy : ContentPage
	{
		public Timmy ()
		{
			InitializeComponent ();
		}


	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        DisplayAlert("Placeholder", "Denna knapp ska leda till Christers sida", "Ok");
	    }

	    private void Button_OnClicked1(object sender, EventArgs e)
	    {
	        DisplayAlert("Placeholder", "Denna knapp ska leda till Marcos sida", "Ok");
	    }
    }
}