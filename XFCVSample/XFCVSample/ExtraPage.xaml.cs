using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFCVSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExtraPage : ContentPage
	{
		public ExtraPage ()
		{
			InitializeComponent ();
		}

        private void ClickMeButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Test", "I am clicked!", "Ok");
        }
    }
}