using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using MaterialKit.WinForm.Properties;

namespace MaterialKit.WinForm
{
    /// <summary> Набор шрифтов MaterialKit </summary>
    public class FontKit
    {
        /// <summary> Инстанс для работы со шрифтами </summary>
        public static FontKit Instance { get; }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        private static uint _cFonts = 0;
        private static PrivateFontCollection _fontsCollection = new PrivateFontCollection();

        static FontKit()
        {
            if(Instance==null)
                Instance = new FontKit();
        }

        public FontKit()
        {
            AddFont(Resources.Roboto_Black);
            AddFont(Resources.Roboto_BlackItalic);
            AddFont(Resources.Roboto_Bold);
            AddFont(Resources.Roboto_BoldItalic);
            AddFont(Resources.Roboto_Italic);
            AddFont(Resources.Roboto_Light);
            AddFont(Resources.Roboto_LightItalic);
            AddFont(Resources.Roboto_Medium);
            AddFont(Resources.Roboto_MediumItalic);
            AddFont(Resources.Roboto_Regular);
            AddFont(Resources.Roboto_Thin);
            AddFont(Resources.Roboto_ThinItalic);
        }

        private static void AddFont(byte[] fontdata)
        {
            int fontLength; 
            System.IntPtr dataPointer;
            dataPointer = Marshal.AllocCoTaskMem(fontdata.Length);
            Marshal.Copy(fontdata, 0, dataPointer, (int)fontdata.Length);
            AddFontMemResourceEx(dataPointer, (uint)fontdata.Length, IntPtr.Zero, ref _cFonts);
            _cFonts += 1;
            _fontsCollection.AddMemoryFont(dataPointer, (int)fontdata.Length);
        }


        public Font Get(FontStyle style, float size)
        {
            return new Font(_fontsCollection.Families[(int)style],size);
        }

        public Font Get(FontStyle style, float size, System.Drawing.FontStyle winStyle)
        {
            return new Font(_fontsCollection.Families[(int)style], size,winStyle);
        }
    }
}
