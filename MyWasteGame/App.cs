using MyWasteGame.DAL.DataServices;
using MyWasteGame.PlatformServices;
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
			DataServices.Init(true, DependencyService.Get<IPlatformService>().GetFilePath("local.db"));

		}


		protected override void OnStart ()
		{
			NavigationService.Instance.SetMainPage(AppPages.GameIntro);
		}
	}
}

