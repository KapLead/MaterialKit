using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using MaterialKit.WinForm.Annotations;

namespace MaterialKit.WinForm.Controls
{
    public partial class Label : UserControl, INotifyPropertyChanged
    {
        private string _text;

        [Category("Kit")]
        public string Text {
            get => _text;
            set
            {
                if (value == _text) return;
                _text = value;
                Invalidate();
                OnPropertyChanged();
            }
        }



        public Label()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
