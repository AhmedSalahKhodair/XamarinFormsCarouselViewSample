using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFCVSample.CarouselViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View2 : ContentView
	{
		public View2 ()
		{
			InitializeComponent ();
		}

        private void NavigationButtonClick(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ExtraPage());
        }
    }
}