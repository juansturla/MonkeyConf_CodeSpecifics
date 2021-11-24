using System;
using Android.Widget;

namespace MonkeyConf.Platforms.Android
{
    public partial class Tostadora
    {
        public void HacerTostadas(string textToShow)
        {
            var context = MainApplication.Context;
            Toast tostada = new Toast(context);
            tostada.SetText(textToShow);
            tostada.Show();
        }
    }
}

