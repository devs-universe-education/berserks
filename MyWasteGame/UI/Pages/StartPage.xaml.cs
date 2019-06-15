using System;
using Xamarin.Forms;

namespace MyWasteGame.UI.Pages {
	public partial class StartPage : BasePage {
		public StartPage() {
			InitializeComponent();
		}
		public async void FirstLevelClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new LevelIntroPage());
		}

		public async void SecondLevelClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new SecondLevelPage());
		}

		public async void ThirdLevelClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new ThirdLevelPage());
		}
	}
}