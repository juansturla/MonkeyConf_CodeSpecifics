using System;
using Foundation;
using UIKit;

//Cuidado con los espacios de nombres!
//namespace MonkeyConf.Platforms.iOS
namespace MonkeyConf
{
    public partial class OpenSettings
    {
        partial void OpenWifiSettings()
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
        }
    }
}

