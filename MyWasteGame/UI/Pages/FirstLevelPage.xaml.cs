using System;

namespace MyWasteGame.UI.Pages {
	public partial class FirstLevelPage: BasePage {
		public FirstLevelPage() {
			InitializeComponent();
		}

		public async void StepBackClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new FirstLevelPage());
		}

		public async void OnFirstImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new SuccessPage());
		}

		public async void OnSecondImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new FirstMistakePage());
		}

		public async void OnThirdImageButtonClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new FirstMistakePage());
		}
	}
}