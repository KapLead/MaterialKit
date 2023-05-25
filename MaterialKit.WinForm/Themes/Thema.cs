using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MaterialKit.WinForm.Annotations;

namespace MaterialKit.WinForm.Themes
{
    public class Thema : INotifyPropertyChanged
    {
        public static event EventHandler KitChangeThema;

        public static Thema Default { get; private set; }

        public ColorSheme Shema {
            get => _shema;
            private set
            {
                if (Equals(value, _shema)) return;
                _shema = value;
                OnPropertyChanged();
                KitChangeThema?.Invoke(this,EventArgs.Empty);
            }
        } private ColorSheme _shema;

        static Thema()
        {
            Default = new Thema();
        }

        public Thema(ColorSheme shema=null)
        {
            if (shema == null) 
                shema = ColorSheme.Classic;
            else
                Shema = shema;
        }

        public static void Initialization(ColorSheme thema) => Default = new Thema(thema);
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
