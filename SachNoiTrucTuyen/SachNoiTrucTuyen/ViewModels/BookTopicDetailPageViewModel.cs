using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SachNoiTrucTuyen.ViewModels
{
    public class BookTopicDetailPageViewModel : BindableBase, INavigationAware
    {
        private ObservableCollection<LayoutPageModel> _layoutPages;
        public ObservableCollection<LayoutPageModel> LayoutPages
        {
            get => _layoutPages;
            set => SetProperty(ref _layoutPages, value);
        }
        private string _titlePage;
        public string TitlePage
        {
            get => _titlePage;
            set => SetProperty(ref _titlePage, value);
        }
        public BookTopicDetailPageViewModel()
        {
            SetSource();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            var topic = parameters.GetValue<string>("topic");
            if (!String.IsNullOrEmpty(topic))
            {
                TitlePage = topic;
            }
        }
        public void SetSource()
        {
            LayoutPages = new ObservableCollection<LayoutPageModel>()
            {
                 new LayoutPageModel() {Type = 1, Image = "", Title = "Mới phát hành", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Gợi ý ngẫu nhiên", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Được đọc nhiều", ListBook = App.Books},
            };
        }
    }
}
