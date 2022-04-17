using Android.Content;
using Android.Text;
using CustomRenderer.Droid;
using SachNoiTrucTuyen.Views.CustomView;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRender))]

namespace CustomRenderer.Droid
{
    public class CustomLabelRender : LabelRenderer
    {
        public CustomLabelRender(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Xamarin.Essentials.DeviceInfo.Version.Major >= 8)
            {
                if (Control != null)
                {
                    Control.JustificationMode = JustificationMode.InterWord;
                }
            }
        }
    }
}