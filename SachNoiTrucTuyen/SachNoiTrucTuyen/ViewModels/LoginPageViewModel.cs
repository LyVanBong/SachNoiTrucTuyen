using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(Password))
                {
                    IsEnabled = true;
                }
                else
                {
                    IsEnabled = false;
                }
                SetProperty(ref _username, value);
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(Username))
                {
                    IsEnabled = true;
                }
                else
                {
                    IsEnabled = false;
                }
                SetProperty(ref _password, value);
            }
        }

        private bool _isFocused;

        public bool IsFocused
        {
            get => _isFocused;
            set => SetProperty(ref _isFocused, value);
        }

        private bool _isEnabled;

        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        public LoginPageViewModel(INavigationService navigationService)
        {
            LoginCommand = new Command(() =>
            {
                Preferences.Set("IsLogin", true);
                IsFocused = false;
                navigationService.NavigateAsync("NavigationPage/MainPage", null, true, true);
            });
        }

        public Command LoginCommand { get; set; }
    }
}