using System;

namespace MyWasteGame.DAL.DataServices
{
	public static class DataServices {
		public static IMainDataService Main { get; private set; }

		public static void Init(bool isMock, string filePath) {
			if (isMock) {
				Main = new Mock.MainDataService();
			}
			else {
				Main = new Database.MainDataService(filePath);
			}
		}
	}
}

