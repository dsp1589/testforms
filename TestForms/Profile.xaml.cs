using System;
using System.Collections.Generic;

using Xamarin.Forms;


namespace TestForms
{
    public partial class Profile : ContentPage
    {
        public Profile()
        {
			InitializeComponent();
			//this.Padding = new Thickness(0, Device.RuntimePlatform == "iOS" ? 20 : 0, 0, 0);

			Title = "Profile";
			if (Xamarin.Forms.Device.RuntimePlatform == "iOS")
			{
				Icon = "profile";
			}
        }
    }
}
