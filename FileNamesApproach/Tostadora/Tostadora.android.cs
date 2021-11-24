using System;
using Android.Widget;

//Cuidado con los espacios de nombres!
//namespace MonkeyConf.Platforms.Android
namespace MonkeyConf
{
    public partial class Tostadora
    {
        partial void HacerTostadas(string textToShow)
        {
            var context = MainApplication.Context;
            Toast tostada = new Toast(context);
            tostada.SetText(textToShow);
            tostada.Show();
        }
    }
}

