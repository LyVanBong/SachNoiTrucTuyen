using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace SachNoiTrucTuyen.ViewModels
{
    public class PostCommentPageViewModel : BindableBase, INavigationAware
    {
        private int _idStt;
        public int IdStt { get => _idStt; set => SetProperty(ref _idStt, value); }
        private ObservableCollection<Comment> _comments;
        public ObservableCollection<Comment> StatusComments { get => _comments; set => SetProperty(ref _comments, value); }

        public PostCommentPageViewModel()
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            IdStt = parameters.GetValue<int>("IdStt");
            if (IdStt.ToString().StartsWith("1"))
            {
                StatusComments = new ObservableCollection<Comment>(App.Posts.FirstOrDefault(p => p.Id == IdStt).Comments);
            }
            else
            {
                StatusComments = new ObservableCollection<Comment>(App.EveryOnePosts.FirstOrDefault(p => p.Id == IdStt).Comments);
            }
        }
    }
}