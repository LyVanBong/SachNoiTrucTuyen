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
    public class PremiumPageViewModel : BindableBase
    {
        public ObservableCollection<ItemWelcomePage> ItemPremiumPages { get; set; }
        private int _position = 0;
        public int Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }
        public string[] Descriptions = new string[]
        {
            "7 ngày đầu tiên dùng thử miễn phí, sau đó bạn sẽ bị tính phí 99.000 đ mỗi tháng",
            "7 ngày đầu tiên dùng thử miễn phí, sau đó bạn sẽ bị tính phí 249.000 đ mỗi 3 tháng",
            "7 ngày đầu tiên dùng thử miễn phí, sau đó bạn sẽ bị tính phí 699.000 đ mỗi năm"
        };
        private string _descripton = "7 ngày đầu tiên dùng thử miễn phí, sau đó bạn sẽ bị tính phí 99.000 đ mỗi tháng";
        public string Description
        {
            get => _descripton;
            set => SetProperty(ref _descripton, value);
        }
        public PremiumPageViewModel()
        {
            ItemPremiumPages = new ObservableCollection<ItemWelcomePage>()
            {
                new ItemWelcomePage()
                {
                    Title = "Nâng cấp PREMIUM",
                    SubTitle = "Nghe và đọc tất cả nội dung",
                    Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_p_1.png"),
                  
                }
                ,
                new ItemWelcomePage()
                {
                    Title = "Tính năng playlist",
                    SubTitle = "Phát audio hàng loạt theo tuyển tập",
                    Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_p_2.png"),
                }
                ,
                new ItemWelcomePage()
                {
                    Title = "Cộng đồng",
                    SubTitle = "Viết cảm nhận và tương tác với cộng đồng người yêu sách",
                    Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_p_3.png"),
                   

                }
                ,
                new ItemWelcomePage()
                {
                    Title = "No Ads",
                    SubTitle = "Không còn quảng cáo",
                    Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_p_4.png"),


                }
                ,
                new ItemWelcomePage()
                {
                    Title = "Quyền lợi của bạn",
                    Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_welcome_2.png"),
                    Description = " ° Nghe va đọc tất cả nội dung. \n ° Phát liên tục nhiêu audio. \n ° Cá nhân hoá trải nghiệm bằng “danh sách yêu thích. \n ° Nghe những tuyển tập được BTV tuyển chọn. \n ° Viết bài cảm nhận và tương tác với cộng đồng \n ° Không bị quảng cáo làm phiên.",
                    IsDescriptionOnly = true
                }
            };
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                Position = Position <= 3 ? Position + 1 : 0;
                return true;
            });


            RadioCheckedCommand = new Command((x) =>
            {
                var btn = x as RadioButton;
                switch(btn.ClassId)
                {
                    case "rd99": Description = Descriptions[0]; break;
                    case "rd249": Description = Descriptions[1]; break;
                    case "rd699": Description = Descriptions[2]; break;
                }
            });
        }
        public Command RadioCheckedCommand { get; set; }
    }
}
