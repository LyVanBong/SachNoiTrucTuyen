using Prism;
using Prism.Ioc;
using SachNoiTrucTuyen.Models;
using SachNoiTrucTuyen.ViewModels;
using SachNoiTrucTuyen.Views;
using SachNoiTrucTuyen.Views.Pages;
using SachNoiTrucTuyen.Views.Pages.DetailPages;
using SachNoiTrucTuyen.Views.Pages.FunctionPages;
using SachNoiTrucTuyen.Views.Pages.SupportPages;
using SachNoiTrucTuyen.Views.Pages.TabbedPages;
using System.Collections.ObjectModel;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
[assembly: ExportFont("Roboto-Black.ttf", Alias = "RB")]
[assembly: ExportFont("Roboto-BlackItalic.ttf", Alias = "RBI")]
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "RBo")]
[assembly: ExportFont("Roboto-BoldItalic.ttf", Alias = "RBoI")]
[assembly: ExportFont("Roboto-Italic.ttf", Alias = "RI")]
[assembly: ExportFont("Roboto-Light.ttf", Alias = "RL")]
[assembly: ExportFont("Roboto-LightItalic.ttf", Alias = "RLI")]
[assembly: ExportFont("Roboto-Medium.ttf", Alias = "RM")]
[assembly: ExportFont("Roboto-MediumItalic.ttf", Alias = "RMI")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "R")]
[assembly: ExportFont("Roboto-Thin.ttf", Alias = "RT")]
[assembly: ExportFont("Roboto-ThinItalic.ttf", Alias = "RTI")]
namespace SachNoiTrucTuyen
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjAwMTk2QDMxMzkyZTM0MmUzMGY1eW1PM3FpcEhLZkhtZzlwcjR2cXYyWEZIc0J2YmJ5ZGYyNFVka0Z3RVU9");
            InitializeComponent();
            await NavigationService.NavigateAsync("/SplashScreenPage");
        }

        public static ObservableCollection<Book> Books = new ObservableCollection<Book>()
        {
            new Book()
            {
                ImgBook="https://dl.dropboxusercontent.com/s/ug4kuaa4ynuarcu/bi-quyet-hanh-phuc-cua-su-thay-20210412074657.jpg?dl=0",
                TitleBook = "Bí quyết hạnh phúc của sư thầy",
                AuthorBook = "Gelong Thubten"
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/z8nsimy1av2zd42/hanh-dong-bang-suc-manh-20210412074657.jpg?dl=0",
                TitleBook = "Hành động bằng sức mạnh",
                AuthorBook = "Deborad Gruenfeld"
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/4596m7cvp4ybj5u/hay-bat-toi-neu-ban-co-the-20210412074657.jpg?dl=0",
                TitleBook = "Hãy bắt tôi nếu có thể",
                AuthorBook = "Frank Abagnale",
                IsPremium = false
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/2n3vivoujq6thqg/loi-nguyen-cua-su-to-lon-20210412074657.jpg?dl=0",
                TitleBook = "Lời nguyền của sự to lớn",
                AuthorBook = "Tim Wu"
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/lp9hmx94fif37ub/nha-lanh-dao-linh-hoat-20210412074657.jpg?dl=0",
                TitleBook = "Nhà lãnh đạo linh hoạt",
                AuthorBook = "Simon Hayward",
                IsPremium = false
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/eg0kjss8oyrdzex/phuong-trinh-dai-so-cua-hanh-phuc-update-20210414083233.jpg?dl=0",
                TitleBook = "Phương trình đại số của hạnh phúc",
                AuthorBook = "Scott Galloway"
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/275jjju11hrlsvx/suc-manh-cua-thoi-quen-20210412081444.jpg?dl=0",
                TitleBook = "Súc mạnh của thói quen",
                AuthorBook = "Charles Duhigg",
                IsPremium = false
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/khidq2q6ihg2xa7/thai-do-phan-anh-kha-nang-lanh-dao-20210412081444.jpg?dl=0",
                TitleBook = "Thái độ phản ánh khả năng lãnh đạo",
                AuthorBook = "Leo Hamblin"
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/w7fvqu685dn04zv/tham-hoa-chernobyl-20210412081444.jpg?dl=0",
                TitleBook = "Thảm họa Chernobyl",
                AuthorBook = "Serhii Plokhi"
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/unairj46gyqen79/that-lung-buoc-bung-20210412081444.jpg?dl=0",
                TitleBook = "Thắt lưng buộc bụng",
                AuthorBook = "Alberto Alesina, Carlo Faverro, Francesco Giavazzi",
                IsPremium = false
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/jah5t0jvxroii1s/thay-doi-de-thich-nghi-20210412081444.jpg?dl=0",
                TitleBook = "Thay dổi để thích nghi",
                AuthorBook = "Tim Harford"
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/91hrpn5mmhyfdth/tieu-chuan-bitcoin-20210414083221.jpg?dl=0",
                TitleBook = "Tiêu chuẩn Bitcoin",
                AuthorBook = "Saifedean Ammous"
            },
            new Book() 
            {
                ImgBook="https://dl.dropboxusercontent.com/s/a3cb9izjduksyx5/trieu-phu-moi-ngay-20210412081444.jpg?dl=00",
                TitleBook = "Triệu phú mỗi ngày",
                AuthorBook = "Cris Hogan",
                IsPremium = false
            },

        };
        public static ObservableCollection<Audio> Storys = new ObservableCollection<Audio>()
        {
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/p6t9cu8o51kcyz1/1-20210412102024.jpg?dl=0",
                TitleAudio = "Sukhoi Corp - \"Ông Trùm\" sản xuất máy bay chiến đấu Nga",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/ytmb165o97c040a/2-20210412102024.jpg?dl=0",
                TitleAudio = "Jim Rogers - Huyền thoại đầu tư, từng \"mù tịt\" về chứng khoán",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/bq9ve73pt0ftgrt/3-20210412102024.jpg?dl=0",
                TitleAudio = "Lê Viết Nam - \"Ông vua cáp treo\", người sáng lập tập đoàn Sun Group",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/gjsh22xm5t96r4g/4-20210412102024.jpg?dl=0",
                TitleAudio = "Đào Hoa Bích - Góa phụ mù chữ trở thành tỷ phú nhờ \"ớt chưng dầu\"",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/lt7x3z21z7bsivf/5-20210412102024.jpg?dl=0",
                TitleAudio = "Austin Russell - Tỷ phú tự thân trẻ tuổi nhất thế giới",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/0t7ml7taqkgo650/6-20210412102024.jpg?dl=0",
                TitleAudio = "Antoni Gaudi - \"Kiến trúc sư của chúa\", cha đẻ của 7 di sản văn hóa TG",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/jqvrll8jcnvu6yl/10-20210412102025.jpg?dl=0",
                TitleAudio = "Peter Drucker - \"Cha đẻ\" của quản trị học hiện đại",
                IsFavoriteAudio = false
            }
        };
        public static ObservableCollection<Audio> Knowledges = new ObservableCollection<Audio>()
        {
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/p6t9cu8o51kcyz1/1-20210412102024.jpg?dl=0",
                TitleAudio = "Sukhoi Corp - \"Ông Trùm\" sản xuất máy bay chiến đấu Nga",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/ytmb165o97c040a/2-20210412102024.jpg?dl=0",
                TitleAudio = "Jim Rogers - Huyền thoại đầu tư, từng \"mù tịt\" về chứng khoán",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/bq9ve73pt0ftgrt/3-20210412102024.jpg?dl=0",
                TitleAudio = "Lê Viết Nam - \"Ông vua cáp treo\", người sáng lập tập đoàn Sun Group",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/gjsh22xm5t96r4g/4-20210412102024.jpg?dl=0",
                TitleAudio = "Đào Hoa Bích - Góa phụ mù chữ trở thành tỷ phú nhờ \"ớt chưng dầu\"",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/lt7x3z21z7bsivf/5-20210412102024.jpg?dl=0",
                TitleAudio = "Austin Russell - Tỷ phú tự thân trẻ tuổi nhất thế giới",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/0t7ml7taqkgo650/6-20210412102024.jpg?dl=0",
                TitleAudio = "Antoni Gaudi - \"Kiến trúc sư của chúa\", cha đẻ của 7 di sản văn hóa TG",
                IsFavoriteAudio = false
            },
            new Audio()
            {
                ImgAudio="https://dl.dropboxusercontent.com/s/jqvrll8jcnvu6yl/10-20210412102025.jpg?dl=0",
                TitleAudio = "Peter Drucker - \"Cha đẻ\" của quản trị học hiện đại",
                IsFavoriteAudio = false
            }
        };

        public static ObservableCollection<Notification> Notifications = new ObservableCollection<Notification>()
        {
            new Notification() {Title = "Sách khuyên đọc", Description = "Kỷ luật không cứng nhắc - Phương pháp xoa dịu và phát triển trí não của trẻ", Time = System.DateTime.Now, IsActive = false},
            new Notification() {Title = "Sách khuyên đọc", Description = "Những kẻ khốn khổ nơi công sở - Làm sao để nơi làm việc trở nên thông minh hơn", Time = System.DateTime.Now, IsActive = false},
            new Notification() {Title = "Sách mới phát hành", Description = "Những cô gái Radium - Góc khuất về ngành công nghiệp phóng xạ của Mỹ", Time = System.DateTime.Now, IsActive = true},
            new Notification() {Title = "Sách khuyên đọc", Description = "Huyền thoại về Cholesterol - Những lầm tưởng về Cholesterol và bệnh tim mạch", Time = System.DateTime.Now, IsActive = true},
            new Notification() {Title = "Sách mới phát hành", Description = "Câu chuyện cơ thể con người - Tiến hóa, sức khỏe và bệnh tật", Time = System.DateTime.Now, IsActive = true},
            new Notification() {Title = "Kiến thức tinh gọn", Description = "Phân tích sự sụp đổ của \"đại gia\" năng lượng Hoa Kỳ những năm 1990", Time = System.DateTime.Now, IsActive = true},
            new Notification() {Title = "Tiểu sử doanh nhân", Description = "Chàng trai Ấn Độ bỏ học lập nên chuỗi khách sạn trị giá 10 tỷ USD", Time = System.DateTime.Now, IsActive = true}
        };

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
           

            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SplashScreenPage, SplashScreenPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<StoryPage, StoryPageViewModel>();
            containerRegistry.RegisterForNavigation<KnowledgePage, KnowledgePageViewModel>();
            containerRegistry.RegisterForNavigation<CollectionPage, CollectionPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountPage, AccountPageViewModel>();
            containerRegistry.RegisterForNavigation<MailPage, MailPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchPage, SearchPageViewModel>();
            containerRegistry.RegisterForNavigation<BookDetailPage, BookDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ReadBookPage, ReadBookPageViewModel>();
            containerRegistry.RegisterForNavigation<VoiceBookPage, VoiceBookPageViewModel>();
            containerRegistry.RegisterForNavigation<VoiceVideoPage, VoiceVideoPageViewModel>();
            containerRegistry.RegisterForNavigation<BookTopicDetailPage, BookTopicDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<StoryTopicDetailPage, StoryTopicDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<KnowledgeTopicDetailPage, KnowledgeTopicDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<WelcomePage, WelcomePageViewModel>();
            containerRegistry.RegisterForNavigation<LoginAndSignupPage, LoginAndSignupPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<SignupPage, SignupPageViewModel>();
            containerRegistry.RegisterForNavigation<NotificationPage, NotificationPageViewModel>();
        }
    }
}
