using System;
namespace MyWasteGame.UI.Pages {
	public partial class ThirdMistakePage : BasePage {
		public ThirdMistakePage() {
			InitializeComponent();
		}
		public async void MistakeStepBackClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new ThirdLevelPage());
		}
	}
}