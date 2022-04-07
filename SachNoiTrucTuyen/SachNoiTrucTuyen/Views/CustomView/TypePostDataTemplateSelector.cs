using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.Views.CustomView
{
    public class TypePostDataTemplateSelector : DataTemplateSelector
    {   
        public DataTemplate PostTopic { get; set; }
        public DataTemplate PostWithImage { get; set; }
        public DataTemplate PostWithListChoose { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (item as Post).TypePost == 0 ? PostWithImage : ((item as Post).TypePost == 1 ? PostWithListChoose : PostTopic);
        }
    }
}
