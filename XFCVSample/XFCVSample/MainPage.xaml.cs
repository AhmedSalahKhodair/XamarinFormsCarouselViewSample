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

            MyDataSource = new List<CarouselData>() { new CarouselData() { Name = "View1" },
                                                      new CarouselData() { Name = "View2" },
                                                      new CarouselData() { Name = "View3" },
                                                      new CarouselData() { Name = "View4" }};

            BindingContext = this;
        }
        public List<CarouselData> MyDataSource { get; set; } // Must have default value or be set before the BindingContext is set.

        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }
    }
}
