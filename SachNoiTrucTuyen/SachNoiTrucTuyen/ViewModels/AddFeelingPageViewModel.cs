using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SachNoiTrucTuyen.ViewModels
{
    public class AddFeelingPageViewModel : BindableBase
    {
        private string _content;
        public string Content
        {
            get => _content;
            set { IsFullCharacter = value.Length >= 100 ? true : false; SetProperty(ref _content, value); }
        }
        private bool _isFullCharacter;
        public bool IsFullCharacter
        {
            get => _isFullCharacter;
            set => SetProperty(ref _isFullCharacter, value);
        }
        public AddFeelingPageViewModel()
        {

        }
    }
}

