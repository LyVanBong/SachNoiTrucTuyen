using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class FindUserPageViewModel : BindableBase, INavigationAware
    {
        private string _searchContent;

        public string SearchContent
        {
            get => _searchContent;
            set => SetProperty(ref _searchContent, value);
        }

        private ObservableCollection<User> _userResult;

        public ObservableCollection<User> UserResults
        {
            get => _userResult;
            set => SetProperty(ref _userResult, value);
        }

        public FindUserPageViewModel()
        {
            UserResults = App.Users;
            SearchCommand = new Command(() =>
            {
                if (!String.IsNullOrEmpty(SearchContent))
                {
                    UserResults = new ObservableCollection<User>(App.Users.Where(u => u.Name.ToLower().Contains(SearchContent.ToLower())));
                }
                else
                {
                    UserResults = App.Users;
                }
            });
        }

        public Command SearchCommand { get; set; }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}