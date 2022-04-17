using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.ObjectModel;

namespace SachNoiTrucTuyen.ViewModels
{
    public class KnowledgeTopicDetailPageViewModel : BindableBase, INavigatedAware
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

        public KnowledgeTopicDetailPageViewModel()
        {
            ListAudio = App.Knowledges;
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