using System;
namespace MyWasteGame.UI.Pages {
	public partial class SecondMistakePage : BasePage {
		public SecondMistakePage() {
			InitializeComponent();
		}
		public async void MistakeStepBackClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new SecondLevelPage());
		}
	}
}