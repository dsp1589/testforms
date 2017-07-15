using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestForms
{
    public partial class NewClaimPage : ContentPage
    {
        public NewClaimPage()
        {
            InitializeComponent();
            Title = "New Claims";
            if (Xamarin.Forms.Device.RuntimePlatform == "iOS"){
				Icon = "new";
			}
        }
    }
}