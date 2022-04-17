using SachNoiTrucTuyen.Models;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.Views.CustomView
{
    public class SettingItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ItemNoImage { get; set; }
        public DataTemplate ItemWithImage { get; set; }
        public DataTemplate ItemWithSubName { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (item as SettingItem).Type == 0 ? ItemNoImage : ((item as SettingItem).Type == 1 ? ItemWithImage : ItemWithSubName);
        }
    }
}