using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace possibility
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTc3OTY5QDMxMzcyZTMzMmUzMFJpdDBMR1BWanVQU1FzcWlTRE1kcWEzRGhJTmUrN0paQnNXbGVkeWhVR1U9");
            InitializeComponent();

            /*MainPage = new MasterDetailPage()
			{
				Master = new MasterPage() { Title = "Dashboard" },
				Detail = new NavigationPage(new dashboardPage())
			};*/
            MainPage = new MainPage();
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
