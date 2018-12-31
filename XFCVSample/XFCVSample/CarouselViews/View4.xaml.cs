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
	public partial class View4 : ContentView
	{
		public View4 ()
		{
			InitializeComponent ();
            List<string> items = new List<string>() { "Five", "Six", "Seven" };
            defaultPicker.ItemsSource = items;
            customPicker.ItemsSource = items;
        }

        private void CustomPickerSelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CustomPickerFocused(object sender, FocusEventArgs e)
        {
            return;
        }
    }
}