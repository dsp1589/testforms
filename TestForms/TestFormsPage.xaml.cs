using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace TestForms
{
    public partial class TestFormsPage : ContentPage
    {
        private Button SignInButton;
        private Entry OrgNameEntry, UserNameEntry, PasswordEntry;


        public TestFormsPage()
        {
            InitializeComponent();
            SignInButton = this.FindByName<Button>("SignIn");
            SignInButton.Clicked += (sender, e) => {
                this.makeCall(OrgNameEntry.Text, UserNameEntry.Text, PasswordEntry.Text);    
            };
            OrgNameEntry = this.FindByName<Entry>("OrgName");
            UserNameEntry = this.FindByName<Entry>("UserName");
            PasswordEntry = this.FindByName<Entry>("Password");
        }

        protected override void OnAppearing()
        {
            NavigationPage.SetHasNavigationBar(this,false);
			base.OnAppearing();

		}

        private void makeCall(string org = "", string username = "", string password = ""){
            var m = new MainPage();
            Navigation.PushAsync(m);
		}
    }
}
