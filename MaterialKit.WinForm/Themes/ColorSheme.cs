using System.Drawing;

namespace MaterialKit.WinForm.Themes
{

    /// <summary> Цветовая схема </summary>
    public partial class ColorSheme
    {
        public static ColorSheme Default { get; private set; }

        /// <summary> цвет фона окна или контрола </summary>
        public Color Accept { get; private set; }

        /// <summary> цвет фона окна или контрола </summary>
        public Color Background { get; private set; }

        /// <summary> цвет фона активного поля элемента </summary>
        public Color BackFields { get; private set; }
  
        /// <summary> акцентированный цвет фона  </summary>
        public Color BackAccept { get; private set; }

        /// <summary> цвет шрифта окна или контрола </summary>
        public Color Foreground { get; private set; }

        /// <summary> цвет шрифта активного контрола </summary>
        public Color ForeFields { get; private set; }

        /// <summary> акцентированный цвет шрифта  </summary>
        public Color ForeAccept { get; private set; }


        static ColorSheme()
        {
            Default = new ColorSheme();
        }

        public ColorSheme()
        {

        }

        public ColorSheme(Color accept,Color background, Color backFields, Color backAccept, Color foreground, Color foreFields, Color foreAccept)
        {
            Accept = accept;
            Background = background;
            BackFields = backFields;
            BackAccept = backAccept;
            Foreground = foreground;
            ForeFields = foreFields;
            ForeAccept = foreAccept;
        }
    }
}
