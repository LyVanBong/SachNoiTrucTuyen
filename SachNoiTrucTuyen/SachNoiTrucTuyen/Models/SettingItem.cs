using Prism.Navigation;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.Models
{
    public class SettingItem
    {
        public SettingItem(INavigationService navigation)
        {
            NavigationPageCommand = new Command(() =>
            {
                if (Type != 0 && !string.IsNullOrEmpty(NavigationPage))
                {
                    if (Name != "Đăng xuất")
                    {
                        navigation.NavigateAsync("NavigationPage/" + NavigationPage, null, true, true);
                    }
                    else
                    {
                        Preferences.Set("IsLogin", false);
                        navigation.NavigateAsync("NavigationPage/MainPage", null, true, true);
                    }
                }
            });
        }

        public int Type { get; set; }
        public string Name { get; set; }
        public ImageSource Image { get; set; }
        public string NavigationPage { get; set; }
        public string SubName { get; set; }
        private bool _showMoreIsVisible = true;
        public bool ShowMoreIsVisible { get => _showMoreIsVisible; set => _showMoreIsVisible = value; }
        public Command NavigationPageCommand { get; set; }
    }
}