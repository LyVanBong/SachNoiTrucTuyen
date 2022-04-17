using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace SachNoiTrucTuyen.Models
{
    public class LayoutPageModel : BindableBase
    {
        public int Type { get; set; }

        //Type = 0 => ADs, Type = 1 => ListBook, Type = 2 => ListContent
        //
        public string Title { get; set; }

        public string Image { get; set; }

        //
        public ObservableCollection<Book> ListBook { get; set; }

        public ObservableCollection<Audio> ListAudio { get; set; }
        public string[] ListContent { get; set; }
    }
}