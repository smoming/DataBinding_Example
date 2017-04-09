using Xamarin.Forms;

namespace DataBinding_Example
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new DataBinding_ExamplePage();
			//MainPage = new ObjectBindingPage();
			//MainPage = new ObjectBindingTimePage();
			MainPage = new OneWayToSourcePage();
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
