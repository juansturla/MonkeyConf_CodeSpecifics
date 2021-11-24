using System;
using Foundation;
using UIKit;

namespace MonkeyConf.Platforms.iOS
{
    public partial class OpenSettings
    {
        public void OpenWifiSettings()
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
        }
    }
}

