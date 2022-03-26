using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.Views.CustomView
{
    public class CustomLabel : Label
    {
        public static readonly BindableProperty JustifyTextProperty =
            BindableProperty.Create(
                propertyName: nameof(JustifyText),
                returnType: typeof(Boolean),
                declaringType: typeof(CustomLabel),
                defaultValue: false,
                defaultBindingMode: BindingMode.OneWay
         );

        public bool JustifyText
        {
            get { return (Boolean)GetValue(JustifyTextProperty); }
            set { SetValue(JustifyTextProperty, value); }
        }
    }
}
