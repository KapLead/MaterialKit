using System.Drawing;

namespace MaterialKit.WinForm.GraphicsDraws
{
    /// <summary> Яркость цвета палитры </summary>
    public static class BrightnessColor
    {

        /// <summary> Ярче на указанный процент </summary>
        public static Color Brighter(this Color color, Persent persent)
        {
            return Color.FromArgb(color.A.ToIntARGB_add(persent), color.R.ToIntARGB_add(persent), color.G.ToIntARGB_add(persent), color.B.ToIntARGB_add(persent));
        }
       
        /// <summary> Темнее на указанный процент </summary>
        public static Color Darker(this Color color, Persent persent)
        {
            return Color.FromArgb(color.A.ToIntARGB_less(persent), color.R.ToIntARGB_less(persent), color.G.ToIntARGB_less(persent), color.B.ToIntARGB_less(persent));
        }

        /// <summary> увеличение цвета на фиксированный процент </summary>
        public static byte ToIntARGB_add(this byte value, Persent persent)
        {
            var v =value + int.Parse(persent.ToString().Substring(1)) * 255 / 100;
            if (v < 0) v = 0;
            if (v > 255) v = 255;
            return (byte)v;
        }

        /// <summary> уменьшение цвета на фиксированный процент </summary>
        public static byte ToIntARGB_less(this byte value, Persent persent)
        {
            var v = value - int.Parse(persent.ToString().Substring(1)) * 255 / 100;
            if (v < 0) v = 0;
            if (v > 255) v = 255;
            return (byte)v;
        }
    }
}
