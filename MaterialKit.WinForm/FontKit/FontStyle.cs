using System.Drawing;

namespace MaterialKit.WinForm
{
    /// <summary> Вид шрифта </summary>
    public enum FontStyle : int
    {
        Black=0,
        BlackItalic=1,
        Bold=2,
        BoldItalic=3,
        Italic=4,
        Light=5,
        LightItalic=6,
        Medium=7,
        MediumItalic=8,
        Regular=9,
        Thin=10,
        ThinItalic=11,
    }

    public static class ExternFontStyle
    {
        public static Font ToFont(this FontStyle style, FontSize size)
        {
            return FontKit.Instance.Get(style, size.ToSize());
        }
    }
}
