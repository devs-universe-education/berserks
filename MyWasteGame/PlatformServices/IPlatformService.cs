using System.Threading.Tasks;
using Size = Xamarin.Forms.Size;

namespace MyWasteGame.PlatformServices {
    public interface IPlatformService {
		Size ScreenSize { get; }
		void HideKeyboard();
        bool IsLightStatusBar();
        void SetLightStatusBar(bool isLightStatusBar);
        string GetFilePath(string fileName);
	    string GetLocalHtmlBaseUrl();
	    Task<string> GetLocalHtmlContent(string path);
		string GetDeviceName();
    }
}
