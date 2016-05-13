using System;

using Xamarin.Forms;

namespace XamarinFormsPages
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application

			//MainPage = new PagesDemo();
			MainPage = new PagesDemoXaml();
			//MainPage = new MasterDetailSamp();
			//NavigationPage.SetHasNavigationBar (MainPage, false);
			//NavigationPage.SetTitleIcon (MainPage, false);
			NavigationPage.SetHasBackButton (MainPage, true);

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

