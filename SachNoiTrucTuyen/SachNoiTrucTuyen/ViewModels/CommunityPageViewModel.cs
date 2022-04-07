using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using SachNoiTrucTuyen.Models;
using SachNoiTrucTuyen.Views.Pages.DetailPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SachNoiTrucTuyen.ViewModels
{
    public class CommunityPageViewModel : BindableBase
    {   
        public string[] Topics { get; set; }
        public ObservableCollection<Post> Posts { get; set; }
        public ObservableCollection<Post> EveryOnePosts { get; set; }
        public CommunityPageViewModel(INavigationService navigation)
        {
            Topics = new string[] {"Mới nhất", "Khuyên đọc", "Thông báo", "Mini game", "Khảo sát", "Câu chuyện" };
            Posts = App.Posts;
            EveryOnePosts = App.EveryOnePosts;
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
                    case 0: navigation.NavigateAsync("NavigationPage/BookDetailPage",new NavigationParameters() { { "IdBook", post.ItemInPost} }, true, true); break;
                    case 1: navigation.NavigateAsync("NavigationPage/VoiceVideoPage",new NavigationParameters() { { "IdAudio", post.ItemInPost} }, true, true); break;
                    case 2: navigation.NavigateAsync("NavigationPage/VoiceVideoPage",new NavigationParameters() { { "IdAudio", post.ItemInPost} }, true, true); break;
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
