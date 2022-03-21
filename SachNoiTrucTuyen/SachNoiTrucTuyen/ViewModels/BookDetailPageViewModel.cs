using Prism.Commands;
using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class BookDetailPageViewModel : BindableBase
    {
        private bool _showMore = false;
        public bool ShowMore
        {
            get => _showMore;
            set => SetProperty(ref _showMore, value);
        }

        private ObservableCollection<Book> _listBook;
        public ObservableCollection<Book> ListBook
        {
            get => _listBook;
            set => SetProperty(ref _listBook, value);
        }
        public BookDetailPageViewModel()
        {
            ShowMoreCommand = new Command(() =>
            {
                ShowMore = !ShowMore;
            });
            ListBook = App.Books;
        }
        public Command ShowMoreCommand { get; set; }
    }
}
