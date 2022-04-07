using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace SachNoiTrucTuyen.ViewModels
{
    public class UserPageViewModel : BindableBase, INavigationAware
    {
        private User _user;
        public User User { get => _user; set { SetProperty(ref _user, value); } }
        private int _userId;
        public int UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }
        public UserPageViewModel()
        {
            
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            var x = parameters.GetValue<int>("UserId");
            if (x!=0)
            {
                
                User = App.Users.FirstOrDefault(u => u.Id == x);
            }
            else
            {
                return;
            }
            

        }
    }
}
