using System;
using System.IO;
using System.Threading.Tasks;
using MyWasteGame.Android.PlatformServices;
using MyWasteGame.PlatformServices;
using Plugin.CurrentActivity;
using Plugin.DeviceInfo;
using Xamarin.Forms;
using Size = Xamarin.Forms.Size;

[assembly: Dependency(typeof(PlatformService))]
namespace MyWasteGame.Android.PlatformServices {
    public class PlatformService : IPlatformService {
		public Size ScreenSize {
			get {
				var dm = global::Android.App.Application.Context.Resources.DisplayMetrics;
				return new Size((int)(dm.WidthPixels / Density), (int)(dm.HeightPixels / Density));
			}
		}

		public void HideKeyboard() {
        }

        public bool IsLightStatusBar() {
            return false;
        }

        public void SetLightStatusBar(bool isLightStatusBar) {
        }


        public string GetFilePath(string fileName) {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, fileName);
        }

		public string GetLocalHtmlBaseUrl() {
			return @"file:///android_asset/";
		}

		public async Task<string> GetLocalHtmlContent(string path) {
			var assetManager = global::Android.App.Application.Context.Assets;
			using (var streamReader = new StreamReader(assetManager.Open(path)))
				return await streamReader.ReadToEndAsync();
		}

		public string GetDeviceName() {
			return $"{CrossDeviceInfo.Current.Manufacturer} {CrossDeviceInfo.Current.Model}";
		}

		public static float Density => CrossCurrentActivity.Current.AppContext.Resources.DisplayMetrics.Density;
	}
}
