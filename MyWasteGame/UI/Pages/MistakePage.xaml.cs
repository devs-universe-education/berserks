using System;
namespace MyWasteGame.UI.Pages {
	public partial class MistakePage : BasePage {
		public MistakePage() {
			InitializeComponent();
		}
		public async void MistakeStepBackClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new LevelPage());
		}
	}
}