using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.Views.CustomView
{
    public class ItemLayoutMenu : DataTemplateSelector
    {
        public DataTemplate ADs { get; set; }
        public DataTemplate ListBook { get; set; }
        public DataTemplate ListContent { get; set; }
        public DataTemplate ListAudio { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            int type = (item as LayoutPageModel).Type;
            return type == 0 ? ADs : (type == 1 ? ListBook : (type == 2 ? ListContent : ListAudio));
        }
    }
}
