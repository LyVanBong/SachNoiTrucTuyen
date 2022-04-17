using Prism.Mvvm;
using SachNoiTrucTuyen.Models;
using System.Collections.ObjectModel;

namespace SachNoiTrucTuyen.ViewModels
{
    public class KnowledgePageViewModel : BindableBase
    {
        public ObservableCollection<LayoutPageModel> LayoutPages { get; private set; }

        public KnowledgePageViewModel()
        {
            LayoutPages = new ObservableCollection<LayoutPageModel>()
            {
                new LayoutPageModel() {Type = 2, Image = "", Title = "Chủ đề", ListContent = new string[] { "Mới nhất", "Lịch sử thế giới", "Chính trị", "Khám phá", "Phát minh vĩ đại", "Kinh tế - Tài chính", "Khoa học - Công nghê", "Công trình vĩ đại", "Nuôi dạy con"} },
                new LayoutPageModel() {Type = 3, ListAudio = App.Knowledges}
            };
        }
    }
}