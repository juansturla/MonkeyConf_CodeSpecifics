using System;
using Android.Content;
using Android.App;
using Android.Provider;

namespace MonkeyConf.Platforms.Android
{
    public class OpenSettingsAndroid : IOpenSettings
    {
        public OpenSettingsAndroid()
        {
        }

        public void OpenWifiSettings()
        {
            var intent = new Intent(Settings.ActionWifiSettings);
            intent.SetFlags(ActivityFlags.NewTask);
            Application.Context.StartActivity(intent);
        }
    }
}

