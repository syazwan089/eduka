using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Eduka.Control
{
    public class FontAwesomeIcon : Label
    {

        public static string Typeface => Device.RuntimePlatform == Device.Android ? "fa-solid-900" : "FontAwesome5Free-Solid";

        public FontAwesomeIcon()
        {
            FontFamily = Typeface;
        }

        public FontAwesomeIcon(string fontAwesomeIcon = null)
        {
            FontFamily = Typeface; //iOS is happy with this, Android needs a renderer to add ".ttf"
            Text = fontAwesomeIcon;
        }
    }
}
