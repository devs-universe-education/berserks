using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteGame.DAL.DataObjects;
using MyWasteGame.DAL.DataServices;

namespace MyWasteGame.BL.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
	    public ICommand GoToGameIntroCommand => GetNavigateToCommand(AppPages.GameIntro);
    }
}

