using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class SearchPageViewModel : BindableBase, INavigationAware
    {
        private string _typePage;
        public string TypePage
        {
            get => _typePage;
            set => SetProperty(ref _typePage, value);
        }
        private string _searchContent;
        public string SearchContent
        {
            get => _searchContent;
            set => SetProperty(ref _searchContent, value);
        }
        private ObservableCollection<Book> _searchResult;
        public ObservableCollection<Book> SearchResult
        {
            get => _searchResult;
            set => SetProperty(ref _searchResult, value);
        }
       
        public SearchPageViewModel()
        {
            SearchCommand = new Command(() => 
            {   
                if(SearchContent != "")
                {
                    SearchResult = new ObservableCollection<Book>(App.Books.Where(b =>
                    {
                        return b.TitleBook.ToLower().Contains(SearchContent.ToLower()) || b.AuthorBook.ToLower().Contains(SearchContent.ToLower());
                    }));
                }
                else
                {
                    SearchResult = new ObservableCollection<Book>();
                }
            });
        }

        public Command SearchCommand { get; set; }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            var typePage = parameters.GetValue<string>("TypePage");
            switch (typePage)
            {
                case "homePage": TypePage = "sách"; break;
            }
        }
    }
}
