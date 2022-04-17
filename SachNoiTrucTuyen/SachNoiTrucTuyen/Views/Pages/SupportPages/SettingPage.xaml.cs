using SachNoiTrucTuyen.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.Views.Pages.SupportPages
{
    public partial class SettingPage : ContentPage
    {
        private SettingPageViewModel vm;

        public SettingPage()
        {
            InitializeComponent();
            vm = BindingContext as SettingPageViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.IsUserLogin = Preferences.Get("IsLogin", false);
        }
    }
}