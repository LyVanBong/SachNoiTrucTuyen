using Prism.Mvvm;
using Prism.Navigation;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class SplashScreenPageViewModel : BindableBase
    {
        public SplashScreenPageViewModel(INavigationService navigation)
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                if (Preferences.Get("IsLogin", true) == true)
                {
                    navigation.NavigateAsync("NavigationPage/MainPage");
                }
                else
                {
                    navigation.NavigateAsync("NavigationPage/WelcomePage");
                }

                return false;
            });
        }
    }
}