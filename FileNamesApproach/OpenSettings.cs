using System;
namespace MonkeyConf
{
    public partial class OpenSettings
    {
        public void PublicOpenWifiSettings()
        {
            OpenWifiSettings();
        }

        //Los métodos parciales no pueden tener modificadores de acceso
        partial void OpenWifiSettings();
    }
}

