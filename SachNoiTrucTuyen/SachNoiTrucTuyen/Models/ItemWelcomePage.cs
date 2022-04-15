using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.Models
{
    public class ItemWelcomePage
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public ImageSource Image { get; set; } 
        public string Description { get; set; }
        private bool _isDescriptionOnly = false;
        public bool IsDescriptionOnly
        {
            get => _isDescriptionOnly;
            set => _isDescriptionOnly = value;
        }
    }
}
