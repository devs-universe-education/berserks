using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyWasteGame.BL.ViewModels {
	public class  MistakeViewModel: BaseViewModel{
		public ICommand NavigateCommand => GetNavigateToCommand(AppPages.Level);

	}
}