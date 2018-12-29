using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFCVSample.CarouselViews;

namespace XFCVSample
{
    public class CustomDataTemplateSelector : DataTemplateSelector
    {
        private DataTemplate view1 = new DataTemplate(typeof(View1));
        private DataTemplate view2 = new DataTemplate(typeof(View2));
        private DataTemplate view3 = new DataTemplate(typeof(View3));
        private DataTemplate view4 = new DataTemplate(typeof(View4));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            CarouselData current = item as CarouselData;

            if (current.Name == "View1")
                return view1;
            else if (current.Name == "View2")
                return view2;
            else if (current.Name == "View3")
                return view3;
            else
                return view4;
        }

    }
}
