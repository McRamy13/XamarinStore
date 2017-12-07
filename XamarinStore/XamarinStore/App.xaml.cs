
using Xamarin.Forms;
namespace XamarinStore
{

    public partial class App : Application
    {
        public static DBRepository DataRepo { get; set; }
        public App(string filename)
        {
            InitializeComponent();
            DataRepo = new DBRepository(filename);
            MainPage = new XamarinStore.MainPage();
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
