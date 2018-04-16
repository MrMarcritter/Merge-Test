using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Page1());
	    }

	    private void TapGestureRecognizer_OnTapped1(object sender, EventArgs e)
	    {
	        DisplayAlert("Tapped Onboarding", "You tapped Onboarding", "OK");
        }

	    private void TapGestureRecognizer_OnTapped2(object sender, EventArgs e)
	    {
	        DisplayAlert("Tapped Schedule", "You tapped Schedule", "OK");
	    }
	}
}
