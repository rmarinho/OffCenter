using Xamarin.Forms;

namespace MCA
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			DependencyService.Register<ILoginService, LoginService>();
			MainPage = new NavigationPage(new MCAPage());
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
