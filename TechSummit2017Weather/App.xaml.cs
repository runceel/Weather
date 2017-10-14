using Xamarin.Forms;

namespace TechSummit2017Weather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TechSummit2017WeatherPage();
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
