using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace SachNoiTrucTuyen.ViewModels
{
    public class TaggedPageViewModel : BindableBase
    {
        private ObservableCollection<Book> _taggedResult;

        public ObservableCollection<Book> TaggedResult
        {
            get => _taggedResult;
            set => SetProperty(ref _taggedResult, value);
        }

        public TaggedPageViewModel()
        {
            TaggedResult = new ObservableCollection<Book>(App.Books.Skip(2));
        }
    }
}