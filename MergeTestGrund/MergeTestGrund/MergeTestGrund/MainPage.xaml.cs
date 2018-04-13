using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MergeTestGrund
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private async void Button_OnClicked4(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Christer());
	    }

	    private void Button_OnClicked5(object sender, EventArgs e)
	    {
	        DisplayAlert("OMG", "NO PAGE!%¤%¤", ":(");
	    }

	    private async void Button_OnClicked6(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Timmy());
	    }
	}
}
