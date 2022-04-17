using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System.Collections.ObjectModel;

namespace SachNoiTrucTuyen.ViewModels
{
    public class CollectionAudioPageViewModel : BindableBase
    {
        public ObservableCollection<Book> ListCollections { get; set; }

        public CollectionAudioPageViewModel()
        {
            ListCollections = App.Books;
        }
    }
}