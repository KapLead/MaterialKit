using System.Drawing;

namespace MaterialKit.WinForm.Themes
{
    public class ColorSheme
    {
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


    }
}
