using System;
using Foundation;
using UIKit;

namespace MonkeyConf.Platforms.iOS
{
    public class OpenSettingsiOS:IOpenSettings
    {
        public void OpenWifiSettings()
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
        }
    }
}

