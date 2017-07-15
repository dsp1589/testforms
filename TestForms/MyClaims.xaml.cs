using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestForms
{
    public partial class MyClaims : ContentPage
    {
        public MyClaims()
        {
            InitializeComponent();
            Title = "My Claims";
            if (Xamarin.Forms.Device.RuntimePlatform == "iOS")
            {
                Icon = "myclaim";
            }
        }
    }
}
