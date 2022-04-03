using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SachNoiTrucTuyen.ViewModels
{
    public class SignupPageViewModel : BindableBase
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
        private bool _isEnabled;
        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }
        public SignupPageViewModel()
        {

        }
    }
}
