using SachNoiTrucTuyen.ViewModels;

namespace SachNoiTrucTuyen.Views
{
    public partial class MainPage
    {
        private MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            vm = BindingContext as MainPageViewModel;
        }
    }
}