using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class SplashScreenPageViewModel : BindableBase
    {
        public SplashScreenPageViewModel(INavigationService navigation)
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), () => { navigation.NavigateAsync("NavigationPage/WelcomePage"); return false; });
        }
    }
}
