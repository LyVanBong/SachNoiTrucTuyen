using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class FeelingPageViewModel : BindableBase
    {
        public ObservableCollection<Post> Feelings { get; set; }
        public FeelingPageViewModel(INavigationService navigation)
        {
            Feelings = App.Posts;
            ShowMoreCommand = new Command((x) =>
            {
                var post = x as Post;
                post.IsShowMore = !post.IsShowMore;
            });
            LikeCommand = new Command((x) =>
            {
                var post = x as Post;
                post.IsLiked = !post.IsLiked;
            });
            PostClickCommand = new Command((x) =>
            {
                var post = x as Post;
                switch (post.TypeItemInPost)
                {
                    case 0: navigation.NavigateAsync("NavigationPage/BookDetailPage", new NavigationParameters() { { "IdBook", post.ItemInPost } }, true, true); break;
                    case 1: navigation.NavigateAsync("NavigationPage/VoiceVideoPage", new NavigationParameters() { { "IdAudio", post.ItemInPost } }, true, true); break;
                    case 2: navigation.NavigateAsync("NavigationPage/VoiceVideoPage", new NavigationParameters() { { "IdAudio", post.ItemInPost } }, true, true); break;
                }
            });
            SwitchToUserCommand = new Command((x) =>
            {
                var post = x as Post;
                navigation.NavigateAsync("NavigationPage/UserPage", new NavigationParameters() { { "UserId", post.UserId } }, true, true);
            });
        }
        public Command PostClickCommand { get; set; }
        public Command ShowMoreCommand { get; set; }
        public Command SwitchToUserCommand { get; set; }
        public Command LikeCommand { get; set; }
    }
}
