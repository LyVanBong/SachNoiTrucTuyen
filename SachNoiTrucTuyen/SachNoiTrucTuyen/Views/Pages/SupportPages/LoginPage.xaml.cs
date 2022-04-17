using Xamarin.Forms;

namespace SachNoiTrucTuyen.Views.Pages.SupportPages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            entryPass.Unfocus();
            entryUserName.Unfocus();
        }
    }
}