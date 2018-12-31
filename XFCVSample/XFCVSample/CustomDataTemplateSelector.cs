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

        public CustomDataTemplateSelector()
        {

        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            string currentView = item as string;

            if (currentView == "View1")
                return view1;
            else if (currentView == "View2")
                return view2;
            else if (currentView == "View3")
                return view3;
            else
                return view4;
        }

    }
}
