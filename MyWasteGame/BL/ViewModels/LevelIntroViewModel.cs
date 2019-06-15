using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyWasteGame.BL.ViewModels {
	public class LevelIntroViewModel : BaseViewModel {

		public ICommand NavigateToLevelCommand => GetNavigateToCommand(AppPages.FirstLevel);
		public ICommand ReferenceCommand => GetNavigateToCommand(AppPages.Reference);

	}
}