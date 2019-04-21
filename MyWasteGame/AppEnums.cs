namespace MyWasteGame
{
	public enum AppPages {
		Start,
		Level,
		Mistake,
		ComRefer,
		SpecRefer,
		GameIntro,
		LevelIntro
	}

	public enum NavigationMode {
		Normal,
		Modal,
		Root,
		Custom
	}

	public enum PageState {
		Clean,
		Loading,
		Normal,
		NoData,
		Error,
		NoInternet
	}
}

