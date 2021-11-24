using System;
namespace MonkeyConf
{
    public partial class Tostadora
    {
        public void PublicHacerTostadas(string textToShow)
        {
            HacerTostadas(textToShow);
        }
        //Los métodos parciales no pueden tener modificadores de acceso
        partial void HacerTostadas(string textToShow);
    }
}

