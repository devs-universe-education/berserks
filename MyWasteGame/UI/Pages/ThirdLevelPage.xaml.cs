using System;

namespace MyWasteGame.UI.Pages {
	public partial class ThirdLevelPage: BasePage {
		public ThirdLevelPage() {
			InitializeComponent();
		}

		public async void StepBackClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new ThirdLevelPage());
		}

		public async void OnFirstImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new ThirdMistakePage());
		}

		public async void OnSecondImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new ThirdMistakePage());
		}

		public async void OnThirdImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new SuccessPageFinal());
		}
	}
}