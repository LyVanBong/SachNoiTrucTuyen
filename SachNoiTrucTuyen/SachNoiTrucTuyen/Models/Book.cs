using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace SachNoiTrucTuyen.Models
{
    public class Book : BindableBase
    {
            public string ImgBook { get; set; }
            public string TitleBook { get; set; }
            public string AuthorBook { get; set; }
            public string VoiceAuthor { get; set; }
            public string ContentBook { get; set; }
            public string LinkBuyBook { get; set; }

            public int _sttReadBook;
            public int SttReadBook
            { get => _sttReadBook; set => SetProperty(ref _sttReadBook, value); }
            private double _timeOfVoice;
            public double TimeOfVoice
            {
                get => _timeOfVoice; set => SetProperty(ref _timeOfVoice, value); 
            }
        private bool _isPremium = true;
        public bool IsPremium { get => _isPremium; set => SetProperty(ref _isPremium,value); }
        private bool _isFavorite;
        public bool IsFavorite { get => _isFavorite; set => SetProperty(ref _isFavorite, value); }
        
    }
}
