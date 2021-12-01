using Microsoft.Maui.Controls;
using UIKit;
using MonkeyConf.Platforms.iOS;

namespace MonkeyConf
{
	public class Program
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			DependencyService.Register<IOpenSettings, OpenSettingsiOS>();
			UIApplication.Main(args, null, typeof(AppDelegate));
		}
	}
}