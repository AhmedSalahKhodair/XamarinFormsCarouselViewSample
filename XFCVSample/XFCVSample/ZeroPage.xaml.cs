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
	public partial class ZeroPage : ContentPage
	{
		public ZeroPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MainPage());
        }
    }
}