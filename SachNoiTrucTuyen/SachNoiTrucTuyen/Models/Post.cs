using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SachNoiTrucTuyen.Models
{
    public class Post : BindableBase
    {
        public Post()
        {
            SelectChooseCommand = new Command((x) =>
            {
                var itemChoose = x as ChooseItem;
                itemChoose.IsClicked = true;
                App.Posts.FirstOrDefault(p => p.Id == itemChoose.Status).Choices.ForEach((c) => { c.IsClicked = c.Name == itemChoose.Name ? true : false; });
            });
            ChooseSelectedCommand = new Command((x) =>
            {
                var itemChoose = x as ChooseItem;
                App.Posts.FirstOrDefault(p => p.Id == itemChoose.Status).Choices.ForEach((c) => { c.IsChoosed = c.Name == itemChoose.Name ? true : false; c.IsPersentVisible = true; });
                itemChoose.IsClicked = false;
            });
            ClearSelectedCommand = new Command((x) =>
            {
                var itemChoose = x as ChooseItem;
                if (itemChoose.IsChoosed)
                {
                    itemChoose.IsChoosed = false;
                    App.Posts.FirstOrDefault(p => p.Id == itemChoose.Status).Choices.ForEach((c) => { c.IsPersentVisible = false; });
                }
                itemChoose.IsClicked = false;
            });
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Avatar { get; set; }
        public DateTime Created { get; set; }
        public string NameUser { get; set; }
        public string Content { get; set; }

        private bool _isShowMore = false;
        public bool IsShowMore { get => _isShowMore; set => SetProperty(ref _isShowMore, value); }

        public string ItemInPost { get; set; }
        public int TypeItemInPost { get; set; }

        private bool _isLiked = false;

        public bool IsLiked
        {
            get => _isLiked;
            set
            {
                NumberLike = value == true ? NumberLike + 1 : NumberLike - 1;
                SetProperty(ref _isLiked, value);
            }
        }

        private int _numberLike;

        public int NumberLike
        {
            get => _numberLike;
            set => SetProperty(ref _numberLike, value);
        }

        public ObservableCollection<Comment> Comments { get; set; }
        public string Topic { get; set; }
        public int TypePost { get; set; }

        //Type 1
        public string Image { get; set; }

        //Type 2
        public ObservableCollection<ChooseItem> Choices { get; set; }

        public Command SelectChooseCommand { get; set; }
        public Command ChooseSelectedCommand { get; set; }
        public Command ClearSelectedCommand { get; set; }
    }
}