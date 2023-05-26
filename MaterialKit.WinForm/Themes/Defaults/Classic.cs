using System.Drawing;

namespace MaterialKit.WinForm.Themes
{
    public partial class ColorSheme
    {
        public static ColorSheme Classic = new ColorSheme(Colors.Classic_Accept, Colors.Classic_Background, Colors.Classic_BackFields,
            Colors.Classic_BackAccept, Colors.Classic_Foreground, 
            Colors.Classic_ForeFields, Colors.Classic_ForeAccept);

       
        public static ColorSheme Blue = new ColorSheme(Colors.Blue_Accept,Colors.Blue_Background, Colors.Blue_BackFields, 
            Colors.Blue_BackAccept, Colors.Blue_Foreground, 
            Colors.Blue_ForeFields, Colors.Blue_ForeAccept);
    }
}
