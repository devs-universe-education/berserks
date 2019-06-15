using System;

namespace MyWasteGame.UI.Pages {
	public partial class SecondLevelPage: BasePage {
		public SecondLevelPage() {
			InitializeComponent();
		}

		public async void StepBackClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new SecondLevelPage());
		}

		public async void OnFirstImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new SuccessPage());
		}

		public async void OnSecondImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new SecondMistakePage());
		}

		public async void OnThirdImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new SecondMistakePage());
		}
	}
}