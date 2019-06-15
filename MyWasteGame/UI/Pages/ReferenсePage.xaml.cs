using System;
namespace MyWasteGame.UI.Pages {
	public partial class ReferencePage : BasePage {
		public ReferencePage() {
			InitializeComponent();
		}
		public async void ReferenceStepBackClicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new FirstLevelPage());
		}
	}
}