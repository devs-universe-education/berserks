using System;
namespace MyWasteGame.UI.Pages {
	public partial class FirstMistakePage : BasePage {
		public FirstMistakePage() {
			InitializeComponent();
		}
		public async void MistakeStepBackClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new FirstLevelPage());
		}
	}
}