using Prism.Commands;
using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
