using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using SachNoiTrucTuyen.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class WelcomePageViewModel : BindableBase
    {   
        public ObservableCollection<ItemWelcomePage> ItemWelcomePages { get; set; }
        private int _position = 0;
        public int Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }
        
        public WelcomePageViewModel(INavigationService navigation)
        {
            ItemWelcomePages = new ObservableCollection<ItemWelcomePage>()
            {
                new ItemWelcomePage()
                {
                    Title = "Sách tinh gọn",
                    SubTitle = "Tối ưu việc nghe và đọc sách của bạn",
                    Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_welcome_0.png"),
                    Description = " ° Mỗi nội dung được tóm gọn trong vòng 15 phút. \n ° Đơn giản hóa các khái niệm, lý thuyết,...\n ° Nâng cao kiến thức nhanh chóng và dễ dàng."
                }
                ,
                new ItemWelcomePage()
                {
                    Title = "Tiểu sử tinh gọn",
                    SubTitle = "Bài học từ những người thành công",
                    Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_welcome_1.png"),
                    Description = "° Tiểu sử người thành công trong nhiều lĩnh vực. \n° Lịch sử hình thành các doanh nghiệp lớn trên thể giới. \n° Những bài học đắt giá và thực tế trong cuộc sống."

                }
                ,
                new ItemWelcomePage()
                {
                    Title = "Kiến thức tinh gọn",
                    SubTitle = "Những điều có thể bạn chưa biết",
                    Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_welcome_2.png"),
                    Description = "° Mỗi nội dung được tóm gọn trong vòng 15 phút. \n° Đơn giản hóa các khái niệm, lý thuyết,... \n° Nâng cao kiến thức nhanh chóng và dễ dàng."

                }
            };
            PositionChangedCommand = new Command((x) =>
            {
                Position = (int)x;
            });
            SwipeViewCommand = new Command((x) =>
            {
                var carousel = x as CarouselView;
                switch(Position)
                {
                    case 0: Position++; break;
                    case 1: Position++; break;
                    case 2: navigation.NavigateAsync("/LoginAndSignupPage"); break;
                }

            });
        }
        public Command PositionChangedCommand { get; set; }
        public Command SwipeViewCommand { get; set; }
    }
}
