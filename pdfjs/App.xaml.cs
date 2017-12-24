using Xamarin.Forms;

namespace pdfjs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new pdfjsPage("http://media.wuerth.com/stmedia/shop/catalogpages/LANG_it/1637048.pdf");
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
