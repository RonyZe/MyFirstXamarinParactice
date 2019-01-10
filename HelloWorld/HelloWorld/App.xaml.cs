using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //             MainPage = new NavigationPage (new WelcomePage()){BarBackgroundColor=Color.BlanchedAlmond,BarTextColor=Color.Black};

            //             MainPage = new NavigationPage(new ContactsPage());

            MainPage = new ContactsPage();

            //            MainPage = new NavigationPage(new MainPage());
            //            MainPage = new MainPage();
            //           MainPage = new ListDetail (new ImagePage());

//            MainPage = new ContextActions();

            MainPage = new NavigationPage (new ImagePage());
//            MainPage = new ListDetail();

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
