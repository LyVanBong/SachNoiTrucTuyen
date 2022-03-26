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
    public class StoryTopicDetailPageViewModel : BindableBase, INavigationAware
    {
        private ObservableCollection<Audio> _listAudio;
        public ObservableCollection<Audio> ListAudio
        {
            get => _listAudio;
            set => SetProperty(ref _listAudio, value);
        }
        private string _titlePage;
        public string TitlePage
        {
            get => _titlePage;
            set => SetProperty(ref _titlePage, value);
        }
        public StoryTopicDetailPageViewModel()
        {
            ListAudio = App.Storys;
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
    }
}
