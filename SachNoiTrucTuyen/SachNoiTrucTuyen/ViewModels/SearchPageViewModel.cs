using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
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

        private string _placeholderEntry;

        public string PlaceholderEntry
        {
            get => _placeholderEntry;
            set => SetProperty(ref _placeholderEntry, value);
        }

        private bool _isAudioSearch = false;

        public bool IsAudioSearch
        {
            get => _isAudioSearch;
            set => SetProperty(ref _isAudioSearch, value);
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

        private ObservableCollection<Audio> _searchAudioResult;

        public ObservableCollection<Audio> SearchAudioResult
        {
            get => _searchAudioResult;
            set => SetProperty(ref _searchAudioResult, value);
        }

        public SearchPageViewModel()
        {
            SearchCommand = new Command(() =>
            {
                switch (TypePage)
                {
                    case "sách":
                        if (SearchContent != "")
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
                        break;

                    case "tiểu sử":
                        if (SearchContent != "")
                        {
                            SearchAudioResult = new ObservableCollection<Audio>(App.Storys.Where(b =>
                            {
                                return b.TitleAudio.ToLower().Contains(SearchContent.ToLower());
                            }));
                        }
                        else
                        {
                            SearchAudioResult = new ObservableCollection<Audio>();
                        }
                        break;

                    case "kiến thức":
                        if (SearchContent != "")
                        {
                            SearchAudioResult = new ObservableCollection<Audio>(App.Knowledges.Where(b =>
                            {
                                return b.TitleAudio.ToLower().Contains(SearchContent.ToLower());
                            }));
                        }
                        else
                        {
                            SearchAudioResult = new ObservableCollection<Audio>();
                        }
                        break;
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
                case "homePage": TypePage = "sách"; IsAudioSearch = false; PlaceholderEntry = "Nhập tên sách hoặc tác giả..."; break;
                case "storyPage": TypePage = "tiểu sử"; IsAudioSearch = true; PlaceholderEntry = "Nhập tên nhân vật hoặc công ty..."; break;
                case "knowledgePage": TypePage = "kiến thức"; IsAudioSearch = true; PlaceholderEntry = "Nhập từ khóa muốn tìm..."; break;
            }
        }
    }
}