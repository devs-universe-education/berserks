using System;
using Xamarin.Forms;

namespace MyWasteGame.UI.Pages {
	public partial class StartPage : BasePage {
		public StartPage() {
			InitializeComponent();
		}

		public async void Level1_Clicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new LevelPage());
		}
	}
}