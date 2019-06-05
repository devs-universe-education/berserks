using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyWasteGame.BL.ViewModels {
	public class GameIntroViewModel : BaseViewModel {
		public ICommand NavigateCommand => GetNavigateToCommand(AppPages.Start);
	}
}
