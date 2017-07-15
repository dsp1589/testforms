using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestForms
{
    public partial class ApproveReportPage : ContentPage
    {
        public ApproveReportPage()
        {
            InitializeComponent();
            Title = "Approve/Reject";
            if (Xamarin.Forms.Device.RuntimePlatform == "iOS")
            {
                Icon = "approve";
            }
        }
    }
}
