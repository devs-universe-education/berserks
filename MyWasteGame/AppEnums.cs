namespace MyWasteGame
{
	public enum AppPages {
		Start,
		GameIntro,
		LevelIntro,
		Reference,
		Success,
		SuccessFinal,
		FirstLevel,
		SecondLevel,
		ThirdLevel,
		FirstMistakePage,
		SecondMistakePage,
		ThirdMistakePage
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

