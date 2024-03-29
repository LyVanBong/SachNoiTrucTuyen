﻿using Prism;
using Prism.Ioc;
using SachNoiTrucTuyen.Models;
using SachNoiTrucTuyen.ViewModels;
using SachNoiTrucTuyen.Views;
using SachNoiTrucTuyen.Views.Pages;
using SachNoiTrucTuyen.Views.Pages.DetailPages;
using SachNoiTrucTuyen.Views.Pages.FunctionPages;
using SachNoiTrucTuyen.Views.Pages.SettingChildPages;
using SachNoiTrucTuyen.Views.Pages.SupportPages;
using SachNoiTrucTuyen.Views.Pages.TabbedPages;
using System;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk3Nzg3MUAzMjMzMmUzMDJlMzBhRDRSaU1iVURIV050VWkrdS90b2t0cndQNTh2UGpWb0pHOEZTeFZQQlFJPQ==");
            InitializeComponent();
            //Preferences.Set("IsLogin", false);
            Preferences.Set("IsPremium", false);
            await NavigationService.NavigateAsync("/SplashScreenPage");
        }

        public static ObservableCollection<Post> Posts = new ObservableCollection<Post>()
        {
            new Post()
            {
                TypePost = 0,
                UserId = 2,
                NameUser = "Phan Tùng",
                Comments = new ObservableCollection<Comment>()
                {
                    new Comment()
                    {
                        Id = 213,
                        Status = 1123,
                        Name = "Thanh Tú Nguyễn",
                        Avatar = "https://kenh14cdn.com/thumb_w/660/2020/7/17/brvn-15950048783381206275371.jpg",
                        Date = DateTime.Now,
                        Content = "Rất vui được hợp tác với team :))))",
                        ReplyComment = new ObservableCollection<Comment>()
                    }
                    ,
                    new Comment()
                    {
                        Id = 23,
                        Status = 1123,
                        Name = "Duyên Nguyễn",
                        Avatar = "https://kenh14cdn.com/thumb_w/660/2020/7/17/brvn-15950048783381206275371.jpg",
                        Date = DateTime.Now,
                        Content = "Sách hay quá!!!!",
                        ReplyComment = new ObservableCollection<Comment>()
                    }
                    ,
                    new Comment()
                    {
                        Id = 213,
                        Status = 1123,
                        Name = "Đức Giang",
                        Avatar = "https://kenh14cdn.com/thumb_w/660/2020/7/17/brvn-15950048783381206275371.jpg",
                        Date = DateTime.Now,
                        Content = "Xúc động quá nè.........",
                        ReplyComment = new ObservableCollection<Comment>()
                    }
                },
                NumberLike = 82,
                Created = DateTime.Now,
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Avatar = "https://kenh14cdn.com/2019/5/6/e4-1556804137280996840619-15571599881272003882952.jpg",
                Image = "https://kenh14cdn.com/thumb_w/660/2020/7/17/brvn-15950048783381206275371.jpg",
                Id = 1123
            },
            new Post()
            {
                TypePost = 1,
                UserId = 1,
                NameUser= "Diệu Thuần",
                Created = DateTime.Now,
                Content = "Vivamus egestas ut felis id accumsan. Morbi pellentesque ligula vel augue vehicula, ac varius nisl pharetra. Nunc egestas rutrum posuere. Nullam lectus odio, porta ac consequat id, elementum eget erat. Quisque eu odio sit amet enim convallis gravida. Phasellus posuere ex eget orci ornare pulvinar. Nulla eu dolor tristique, condimentum purus vitae, malesuada sem. Nam id erat in lorem tempor porta. Nam imperdiet luctus arcu, eget pretium felis aliquet vel. Sed ac ex sed sem scelerisque rutrum quis ut metus. Quisque euismod ac dui ut malesuada.",
                Avatar = "https://media.tadicdn.com/media/image/s/tdtp/id/610cee400df9386a46462317.jpeg_640x",
                Choices = new ObservableCollection<ChooseItem>()
                {
                    new ChooseItem()
                    {
                        Status = 1124,
                        Name = "Kênh Youtube Người Nổi Tiếng",
                        Persent = 45,
                    },
                    new ChooseItem()
                    {
                        Status = 1124,
                        Name = "Kênh Youtube Người Thành Công",
                        Persent = 15,
                    },
                    new ChooseItem()
                    {
                        Status = 1124,
                        Name = "Kênh Youtube Sách Tinh Gọn",
                        Persent = 15,
                    },
                    new ChooseItem()
                    {
                        Status = 1124,
                        Name = "Bạn bè giới thiệu",
                        Persent = 30,
                    }
                }
                ,
                Id = 1124,
                NumberLike = 12,
                Comments = new ObservableCollection<Comment>()
                {
                    new Comment()
                    {
                        Avatar = "https://media.tadicdn.com/media/image/s/tdtp/id/610cee400df9386a46462317.jpeg_640x",
                        Id = 12,
                        Name = "Diệu Thuần",
                        Date = DateTime.Now,
                        Status = 1124,
                        Content = "Cảm ơn các bạn đã tham gia khảo sát giúp team nhé.",
                        ReplyComment = new ObservableCollection<Comment>()
                    }
                }
            }
        };

        public static ObservableCollection<Post> EveryOnePosts = new ObservableCollection<Post>()
        {
            new Post()
            {
                TypePost = 0,
                UserId  = 2,
                NameUser = "Phan Tùng",
                Comments = new ObservableCollection<Comment>()
                {
                    new Comment()
                    {
                        Id = 213,
                        Status = 2125,
                        Name = "Thanh Tú Nguyễn",
                        Avatar = "https://kenh14cdn.com/thumb_w/660/2020/7/17/brvn-15950048783381206275371.jpg",
                        Date = DateTime.Now,
                        Content = "Thú vị!",
                        ReplyComment = new ObservableCollection<Comment>()
                    }
                    ,
                    new Comment()
                    {
                        Id = 23,
                        Status = 2125,
                        Name = "Duyên Nguyễn",
                        Avatar = "https://kenh14cdn.com/thumb_w/660/2020/7/17/brvn-15950048783381206275371.jpg",
                        Date = DateTime.Now,
                        Content = "Sách hay quá!!!!",
                        ReplyComment = new ObservableCollection<Comment>()
                    }
                },
                NumberLike = 82,
                Created = DateTime.Now,
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Avatar = "https://kenh14cdn.com/2019/5/6/e4-1556804137280996840619-15571599881272003882952.jpg",
                Image = "https://dl.dropboxusercontent.com/s/4596m7cvp4ybj5u/hay-bat-toi-neu-ban-co-the-20210412074657.jpg?dl=0",
                Id = 2125,
                TypeItemInPost = 0
            },
            new Post()
            {
                TypePost = 0,
                NameUser= "Diệu Thuần",
                UserId = 1,
                Created = DateTime.Now,
                Content = "Vivamus egestas ut felis id accumsan. Morbi pellentesque ligula vel augue vehicula, ac varius nisl pharetra. Nunc egestas rutrum posuere. Nullam lectus odio, porta ac consequat id, elementum eget erat. Quisque eu odio sit amet enim convallis gravida. Phasellus posuere ex eget orci ornare pulvinar. Nulla eu dolor tristique, condimentum purus vitae, malesuada sem. Nam id erat in lorem tempor porta. Nam imperdiet luctus arcu, eget pretium felis aliquet vel. Sed ac ex sed sem scelerisque rutrum quis ut metus. Quisque euismod ac dui ut malesuada.",
                Avatar = "https://media.tadicdn.com/media/image/s/tdtp/id/610cee400df9386a46462317.jpeg_640x",
                Id = 2126,
                NumberLike = 12,
                Comments = new ObservableCollection<Comment>()
                {
                    new Comment()
                    {
                        Id = 213,
                        Status = 2125,
                        Name = "Đức Giang",
                        Avatar = "https://kenh14cdn.com/thumb_w/660/2020/7/17/brvn-15950048783381206275371.jpg",
                        Date = DateTime.Now,
                        Content = "Xúc động quá nè.........",
                        ReplyComment = new ObservableCollection<Comment>()
                    },
                    new Comment()
                    {
                        Avatar = "https://media.tadicdn.com/media/image/s/tdtp/id/610cee400df9386a46462317.jpeg_640x",
                        Id = 12,
                        Name = "Diệu Thuần",
                        Date = DateTime.Now,
                        Status = 2126,
                        Content = "Cảm ơn các bạn đã tham gia khảo sát giúp team nhé.",
                        ReplyComment = new ObservableCollection<Comment>()
                    }
                },
                Image = "https://dl.dropboxusercontent.com/s/bq9ve73pt0ftgrt/3-20210412102024.jpg?dl=0",
                TypeItemInPost = 1
            }
        };

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

        public static ObservableCollection<Armorial> Armorials = new ObservableCollection<Armorial>()
        {
            new Armorial()
            {
                Id = 1,
                Avatar = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_a_b.png"),
                Name = "Huy hiệu đồng",
                Contidion = "10 bài viết \n10 lượt theo dõi "
            },
            new Armorial()
            {
                Id = 2,
                Avatar = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_a_s.png"),
                Name = "Huy hiệu bạc",
                Contidion = "50 bài viết \n50 lượt theo dõi "
            },
            new Armorial()
            {
                Id = 3,
                Avatar = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_a_g.png"),
                Name = "Huy hiệu vàng",
                Contidion = "100 bài viết \n100 lượt theo dõi"
            },
            new Armorial()
            {
                Id = 4,
                Avatar = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_a_d.png"),
                Name = "Huy hiệu kim cương",
                Contidion = "500 bài viết \n500 lượt theo dõi "
            },
            new Armorial()
            {
                Id = 5,
                Avatar = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_a_p.png"),
                Name = "Partner NNT Studio",
                Contidion = "Đối tác chính thức của NNT Studio"
            },
            new Armorial()
            {
                Id = 6,
                Avatar = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.logo.png"),
                Name = "Admin NNT Studio",
                Contidion = "Quản trị viên ứng dụng sách tinh gọn"
            }
        };

        public static ObservableCollection<User> Users = new ObservableCollection<User>()
        {
            new User ()
            {
                Id = 1,
                Name = "Diệu Thuần",
                Avatar = "https://media.tadicdn.com/media/image/s/tdtp/id/610cee400df9386a46462317.jpeg_640x",
                IdA = 6,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                AmountFollow = 110,
                AmountLike = 2123,
                AmountPost = 20,
                ScoreInGame = 75,
                ScoreOfGame = 100,
            },
            new User ()
            {
                Id = 2,
                Name = "Phan Tùng",
                Avatar = "https://kenh14cdn.com/2019/5/6/e4-1556804137280996840619-15571599881272003882952.jpg",
                IdA = 1,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                AmountFollow = 110,
                AmountLike = 2123,
                AmountPost = 20,
                ScoreInGame = 75,
                ScoreOfGame = 100,
            }
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
            containerRegistry.RegisterForNavigation<CommunityPage, CommunityPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountPage, AccountPageViewModel>();
            containerRegistry.RegisterForNavigation<HeardRecentlyPage, HeardRecentlyPageViewModel>();
            containerRegistry.RegisterForNavigation<SocialManagerPage, SocialManagerPageViewModel>();
            containerRegistry.RegisterForNavigation<TaggedPage, TaggedPageViewModel>();
            containerRegistry.RegisterForNavigation<FavouriteAudioPage, FavouriteAudioPageViewModel>();
            containerRegistry.RegisterForNavigation<PackManagerPage, PackManagerPageViewModel>();
            containerRegistry.RegisterForNavigation<PostManagerPage, PostManagerPageViewModel>();
            containerRegistry.RegisterForNavigation<FeelingPage, FeelingPageViewModel>();
            containerRegistry.RegisterForNavigation<AddFeelingPage, AddFeelingPageViewModel>();
            containerRegistry.RegisterForNavigation<CollectionAudioPage, CollectionAudioPageViewModel>();
            containerRegistry.RegisterForNavigation<PremiumPage, PremiumPageViewModel>();
            containerRegistry.RegisterForNavigation<SettingPage, SettingPageViewModel>();
            containerRegistry.RegisterForNavigation<MailPage, MailPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchPage, SearchPageViewModel>();
            containerRegistry.RegisterForNavigation<ArmorialPage, ArmorialPageViewModel>();
            containerRegistry.RegisterForNavigation<UserPage, UserPageViewModel>();
            containerRegistry.RegisterForNavigation<FindUserPage, FindUserPageViewModel>();
            containerRegistry.RegisterForNavigation<PostCommentPage, PostCommentPageViewModel>();
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