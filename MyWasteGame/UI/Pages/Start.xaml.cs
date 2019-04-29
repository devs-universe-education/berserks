using Xamarin.Forms;

namespace MyWasteGame.UI.Pages {
	public partial class Start : BasePage {
		public Start() {
			InitializeComponent();
		}

		public async void Level1_Clicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new Level());
		}
	}
}