using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestForms
{
    public partial class ReportsPage : ContentPage
    {
        public ReportsPage()
        {
            InitializeComponent();
            Title = "Reports";
            if (Xamarin.Forms.Device.RuntimePlatform == "iOS")
            {
                Icon = "report";
            }
        }
    }
}
