using Prism.Mvvm;

namespace SachNoiTrucTuyen.Models
{
    public class Audio : BindableBase
    {
        public string ImgAudio { get; set; }
        public string TitleAudio { get; set; }
        public string AuthorAudio { get; set; }
        public double LongAudio { get; set; }
        private bool _isFavoriteAudio;
        public bool IsFavoriteAudio { get => _isFavoriteAudio; set => SetProperty(ref _isFavoriteAudio, value); }
    }
}