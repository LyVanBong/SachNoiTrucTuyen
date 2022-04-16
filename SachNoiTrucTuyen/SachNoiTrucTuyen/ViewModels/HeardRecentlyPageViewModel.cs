using Prism.Commands;
using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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

