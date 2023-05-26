namespace MaterialKit.WinForm
{
    /// <summary> Размер шрифта </summary>
    public enum FontSize
    {
        /// <summary> Обычный </summary>
        Normal,
        /// <summary> Уменьшеный </summary>
        Small,
        /// <summary> Увеличенный </summary>
        Big,
        /// <summary> Обычный +20% </summary>
        Normal20,
        /// <summary> Уменьшеный +20% </summary>
        Small20,
        /// <summary> Увеличенный +20% </summary>
        Big20,
    }


    public static class FontKitSize
    {
        public static float Normal { get; private set; } = 18.25f;
        public static float Big { get; private set; } = 16.25f;
        public static float Small { get; private set; } = 20.25f;
        public static float Normal20 { get; private set; } = 20.25f;
        public static float Big20 { get; private set; } = 18.25f;
        public static float Small20 { get; private set; } = 22.25f;

        public static float ToSize(this FontSize size)
        {
            switch (size)
            {
                case FontSize.Small: return Small;
                case FontSize.Normal20: return Normal20;
                case FontSize.Big: return Big;
                case FontSize.Small20: return Small20;
                case FontSize.Big20: return Big20;
                case FontSize.Normal:
                default: return Normal;
            }
        }
    }
}
