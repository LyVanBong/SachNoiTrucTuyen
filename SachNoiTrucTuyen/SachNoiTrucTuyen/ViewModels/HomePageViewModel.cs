using Prism.Commands;
using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SachNoiTrucTuyen.ViewModels
{   
    public class HomePageViewModel : BindableBase
    {
        public ObservableCollection<LayoutPageModel> LayoutPages { get; set; }
        public HomePageViewModel()
        {
            SetLayout();
        }
        public void SetLayout()
        {
            LayoutPages = new ObservableCollection<LayoutPageModel>()
            {
                new LayoutPageModel() {Type = 0, Image = "https://i.ytimg.com/vi/t9EmtwbIJgk/maxresdefault.jpg", Title = ""},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Sách miễn phí", ListBook = App.Books},
                new LayoutPageModel() {Type = 2, Image = "", Title = "Chủ đề", ListContent = new string[] { "Đã đọc/Nghe", "An bình nội tại", "Kỹ năng giao tiếp", "Quản lý thời gian", "Quản lý doanh nghiệp", "Kinh tế học", "Lịch sử thế giới", "Nuôi dạy con", "Khoa học công nghệ","Chính trị", "Phát triển bản thân","Tư duy lãnh đạo", "Đầu tư tài chính","Tự truyện", "Truyền động lúc","Khởi nghiệp", "Marketing-Bán hàng","Vũ trụ","Sức khở","Tâm lý học","Triết học","Thiên nhiên" } },
                new LayoutPageModel() {Type = 1, Image = "", Title = "Mới phát hành", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Dành cho bạn", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Gợi ý ngẫu nhiên", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Kết nối với thiên nhiên", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Xây dựng mối quan hệ", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Có thể bạn sẽ thích", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Được đọc nhiều", ListBook = App.Books},
                new LayoutPageModel() {Type = 1, Image = "", Title = "Chúng tôi khuyên đọc", ListBook = App.Books},
            };
        }
    }
}
