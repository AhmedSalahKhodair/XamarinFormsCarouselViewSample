using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFCVSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StackLayout stackLayout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0, 20, 0, 0),
                Orientation = StackOrientation.Horizontal
            };
            stackLayout.Children.Add(new Label { Text = "Hello", VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand });

            MyDataSource = new List<CarouselData>() { new CarouselData() { MyStackLayout = stackLayout, Name = "Title1" },
                                                      new CarouselData() { Name = "Title2" },
                                                      new CarouselData() { MyStackLayout = stackLayout, Name = "Title3" },
                                                      new CarouselData() { Name = "Title4" }};

            BindingContext = this;
        }
        public List<CarouselData> MyDataSource { get; set; } // Must have default value or be set before the BindingContext is set.
        public List<StackLayout> MyDataSource1 { get; set; } // Must have default value or be set before the BindingContext is set.

        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }
    }
}
