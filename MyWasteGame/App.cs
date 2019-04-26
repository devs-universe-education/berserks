using MyWasteGame.DAL.DataServices;
using MyWasteGame.UI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyWasteGame
{
	public class App : Application
	{
		public App ()
		{
			DialogService.Init(this);
			NavigationService.Init(this);
			DataServices.Init(true, "local.db");
		}

		protected override void OnStart ()
		{
			NavigationService.Instance.SetMainPage(AppPages.Start);
		}
	}
}

