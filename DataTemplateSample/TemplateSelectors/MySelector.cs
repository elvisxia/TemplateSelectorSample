using DataTemplateSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DataTemplateSample.TemplateSelectors
{
    public class MySelector:DataTemplateSelector
    {
        public DataTemplate PlayTemplate { get; set; }
        public DataTemplate TrackTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (((StreamCollection)item).Track == null)
            {
                return PlayTemplate;
            }
            else
            {
                return TrackTemplate;
            }
            //var itemsControl = ItemsControl.ItemsControlFromItemContainer(container);
            //if (itemsControl.IndexFromContainer(container) % 2 == 0)
            //{
            //    return PlayTemplate;
            //}
            //else
            //{
            //    return TrackTemplate;
            //}
        }
    }
}
