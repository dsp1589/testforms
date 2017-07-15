using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestForms
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
			NavigationPage.SetHasNavigationBar(this, false);

			this.Children.Add(new NewClaimPage());
            this.Children.Add(new MyClaims());
            this.Children.Add(new ReportsPage());
            this.Children.Add(new ApproveReportPage());
            this.Children.Add(new Profile());
            InitializeComponent();

		}
		protected override void OnAppearing()
		{
               base.OnAppearing();

		}
    }

}
