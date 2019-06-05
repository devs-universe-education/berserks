using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteGame.DAL.DataObjects;
using MyWasteGame.DAL.DataServices;

namespace MyWasteGame.BL.ViewModels
{
    public class ReferenсeViewModel : BaseViewModel
    {
		public ICommand NavigateCommand => GetNavigateToCommand(AppPages.Start);
		//public ICommand GoToGameIntroCommand => GetNavigateToCommand(AppPages.GameIntro);
    }
}

