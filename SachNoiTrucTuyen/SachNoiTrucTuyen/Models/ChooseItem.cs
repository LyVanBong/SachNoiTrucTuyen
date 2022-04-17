using Prism.Mvvm;

namespace SachNoiTrucTuyen.Models
{
    public class ChooseItem : BindableBase
    {
        public int Status { get; set; }
        public string Name { get; set; }
        public double Persent { get; set; }
        private bool _isChoosed = false;
        public bool IsChoosed { get => _isChoosed; set => SetProperty(ref _isChoosed, value); }
        private bool _isClicked = false;
        public bool IsClicked { get => _isClicked; set => SetProperty(ref _isClicked, value); }
        private bool _isPersentVisible = false;
        public bool IsPersentVisible { get => _isPersentVisible; set => SetProperty(ref _isPersentVisible, value); }
    }
}