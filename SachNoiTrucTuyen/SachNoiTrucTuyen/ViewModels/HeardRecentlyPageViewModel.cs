using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System.Collections.ObjectModel;

namespace SachNoiTrucTuyen.ViewModels
{
    public class HeardRecentlyPageViewModel : BindableBase
    {
        public ObservableCollection<Book> ListRecents { get; set; }

        public HeardRecentlyPageViewModel()
        {
            ListRecents = App.Books;
        }
    }
}