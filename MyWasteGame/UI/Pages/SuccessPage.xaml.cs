using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWasteGame.UI.Pages {
	public partial class SuccessPage : BasePage {
		public SuccessPage() {
			InitializeComponent();
		}
		public async void NavigateClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new StartPage());
		}
	}
}