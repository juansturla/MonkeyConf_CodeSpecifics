using System;
using Android.Content;
using Android.App;
using Android.Provider;

//Cuidado con los espacios de nombres!
//namespace MonkeyConf.Platforms.Android
namespace MonkeyConf
{
    public partial class OpenSettings
    {
        partial void OpenWifiSettings()
        {
            var intent = new Intent(Settings.ActionWifiSettings);
            intent.SetFlags(ActivityFlags.NewTask);
            Application.Context.StartActivity(intent);
        }
    }
}

