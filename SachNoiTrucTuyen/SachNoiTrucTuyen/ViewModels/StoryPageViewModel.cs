using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System.Collections.ObjectModel;

namespace SachNoiTrucTuyen.ViewModels
{
    public class StoryPageViewModel : BindableBase
    {
        public ObservableCollection<LayoutPageModel> LayoutPages { get; set; }

        public StoryPageViewModel()
        {
            LayoutPages = new ObservableCollection<LayoutPageModel>()
            {
                new LayoutPageModel() {Type = 2, Image = "", Title = "Chủ đề", ListContent = new string[] { "Mới nhất", "Công ty xe hơi", "Nhà khoa học - Nhà phát minh", "Doanh nhân Nhật Bản", "Doanh nhân Phương Tây", "Doanh nhân Châu Á", "Công ty vận tải", "Tác giả", "Công ty vũ khí", "Chính trị gia", "Công ty năng lượng", "Công ty tài chính", "Startup", "Doanh nhân Việt Nam", "Công ty công nghệ", "Doanh nhân Trung Quốc", "Doanh nhân Hàn Quốc", "Nhà đầu tư - Nhà kinh tế học", "Công ty thực phẩm", "Kỹ sư", "Công ty thời trang", "Công ty truyền thông", "Thiên tài", "Lịch sử thế giới", "Công ty Game", "Công ty dược phẩm" } },
                new LayoutPageModel() {Type = 3, ListAudio = App.Storys}
            };
        }
    }
}