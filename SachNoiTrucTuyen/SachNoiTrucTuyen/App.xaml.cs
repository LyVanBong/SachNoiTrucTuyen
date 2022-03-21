using Prism;
using Prism.Ioc;
using SachNoiTrucTuyen.Models;
using SachNoiTrucTuyen.ViewModels;
using SachNoiTrucTuyen.Views;
using SachNoiTrucTuyen.Views.Pages;
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
                AuthorBook = "Frank Abagnale"
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
                AuthorBook = "Simon Hayward"
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
                AuthorBook = "Charles Duhigg"
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
                AuthorBook = "Alberto Alesina, Carlo Faverro, Francesco Giavazzi"
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
                AuthorBook = "Cris Hogan"
            },

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
        }
    }
}
