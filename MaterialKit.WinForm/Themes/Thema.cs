namespace MaterialKit.WinForm.Themes
{
    public class Thema
    {
        public static Thema Default { get; private set; }

        public ColorSheme Shema { get; private set; }

        static Thema()
        {
            Default = new Thema();
        }

        public Thema(ColorSheme shema =null)
        {
            if (shema == null) shema = ColorSheme.Classic;
            Shema = shema;
        }
    }
}
