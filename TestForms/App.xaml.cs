using Xamarin.Forms;

namespace TestForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var rootPage = new NavigationPage(new TestFormsPage());
            MainPage = rootPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
