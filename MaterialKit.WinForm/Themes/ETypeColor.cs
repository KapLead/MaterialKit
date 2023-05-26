using System.Drawing;
using System.Drawing.Drawing2D;

namespace MaterialKit.WinForm.Themes
{
    public enum TypeColor
    {
        Accept,
        Background,
        BackFields,
        BackAccept,
        Foreground,
        ForeFields,
        ForeAccept,
    }

    public static class ExternTypeColor
    {

        /// <summary> Конвертация типа цвета в цвет </summary>
        public static Color ToColor(this TypeColor type)
        {
            if(Thema.Default!=null&&Thema.Default.Shema!=null)
                switch (type)
                {
                    case TypeColor.Accept: return Thema.Default.Shema.Accept;
                    case TypeColor.Background: return Thema.Default.Shema.Background;
                    case TypeColor.BackFields: return Thema.Default.Shema.BackFields;
                    case TypeColor.BackAccept: return Thema.Default.Shema.BackAccept;
                    case TypeColor.Foreground: return Thema.Default.Shema.Foreground;
                    case TypeColor.ForeFields: return Thema.Default.Shema.ForeFields;
                    case TypeColor.ForeAccept: 
                    default: return Thema.Default.Shema.ForeAccept;
                }
            else
                switch (type)
                {
                    case TypeColor.Accept:     return ColorSheme.Classic.Accept;
                    case TypeColor.Background: return ColorSheme.Classic.Background;
                    case TypeColor.BackFields: return ColorSheme.Classic.BackFields;
                    case TypeColor.BackAccept: return ColorSheme.Classic.BackAccept;
                    case TypeColor.Foreground: return ColorSheme.Classic.Foreground;
                    case TypeColor.ForeFields: return ColorSheme.Classic.ForeFields;
                    case TypeColor.ForeAccept:
                    default: return Thema.Default.Shema.ForeAccept;
                }
        }

        public static Brush ToSolidBrush(this TypeColor type)
        {
            return new SolidBrush(type.ToColor());
        }

        public static LinearGradientBrush ToLinearGradient(Point p1, Point p2,TypeColor type1, TypeColor type2)
        {
            return new LinearGradientBrush(p1,p2,type1.ToColor(),type2.ToColor());
        }

        public static Pen ToPen(this TypeColor type,float width=1)
        {
            return new Pen(type.ToColor(),width);
        }

    }
}
