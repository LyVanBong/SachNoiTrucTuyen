using Prism.Mvvm;
using Prism.Navigation;
using SachNoiTrucTuyen.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class SettingPageViewModel : BindableBase
    {
        public ObservableCollection<SettingItem> SettingUserItems { get; set; }
        public ObservableCollection<SettingItem> SettingAppItems { get; set; }
        private bool _isUserLogin = false;

        public bool IsUserLogin
        {
            get => _isUserLogin;
            set => SetProperty(ref _isUserLogin, value);
        }

        public SettingPageViewModel(INavigationService navigation)
        {
            SettingUserItems = new ObservableCollection<SettingItem>()
            {
                new SettingItem(navigation) {Type = 0,Name = "Thông tin tài khoản"},
                new SettingItem(navigation) {Type = 1,Name = "Thông tin cá nhân", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_acc.png"), NavigationPage = "UserPage?UserId=1"},
                new SettingItem(navigation) {Type = 1,Name = "Quản lý gói đăng ký", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_pack.png"), NavigationPage = "PackManagerPage"},
                new SettingItem(navigation) {Type = 1,Name = "Liên kết mạng xã hội",  Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_soc.png"), NavigationPage = "SocialManagerPage"},
                new SettingItem(navigation) {Type = 1,Name = "Quản lý bài viết", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_doc.png"), NavigationPage = "PostManagerPage"},
                new SettingItem(navigation) {Type = 1,Name = "Đã đánh dấu", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_tag.png"), NavigationPage = "TaggedPage"},
                new SettingItem(navigation) {Type = 1,Name = "Audio yêu thích", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_heart.png"), NavigationPage = "FavouriteAudioPage"},
                new SettingItem(navigation) {Type = 1,Name = "Nghe gần đây", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_clock.png"), NavigationPage = "HeardRecentlyPage"},
                new SettingItem(navigation) {Type = 1,Name = "Đăng xuất", ShowMoreIsVisible = false, Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_logout.png"), NavigationPage = "MainPage"},
            };
            SettingAppItems = new ObservableCollection<SettingItem>()
            {
                new SettingItem(navigation) {Type = 0,Name = "Thông tin ứng dụng"},
                new SettingItem(navigation) {Type = 1,Name = "Về chúng tôi", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_about.png"), NavigationPage = ""},
                new SettingItem(navigation) {Type = 1,Name = "Những câu hỏi thường gặp", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_ques.png"), NavigationPage = ""},
                new SettingItem(navigation) {Type = 1,Name = "Điều khoản sử dụng", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_doc_1.png"), NavigationPage = ""},
                new SettingItem(navigation) {Type = 1,Name = "Chính sách bảo mật", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_doc_2.png"), NavigationPage = ""},
                new SettingItem(navigation) {Type = 2,Name = "Phiên bản", Image = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_s_set.png"), SubName = "2.0",ShowMoreIsVisible = false},
            };
        }
    }
}