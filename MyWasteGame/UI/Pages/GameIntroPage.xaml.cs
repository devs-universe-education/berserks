using System;
namespace MyWasteGame.UI.Pages {
	public partial class GameIntroPage : BasePage {
		public GameIntroPage() {
			InitializeComponent();
		}
		public async void GoToStartClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new LevelPage());
		}
	}
}