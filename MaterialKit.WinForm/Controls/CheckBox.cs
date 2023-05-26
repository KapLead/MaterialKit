using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MaterialKit.WinForm.Annotations;

namespace MaterialKit.WinForm.Controls
{
    public partial class CheckBox : UserControl, INotifyPropertyChanged
    {
        private bool _isCheck = false;
        private FontStyle _style = FontStyle.Black;

        public FontStyle Style {
            get => _style;
            set
            {
                if (value == _style) return;
                _style = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        public bool IsCheck {
            get => _isCheck;
            set
            {
                if (value == _isCheck) return;
                _isCheck = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        public CheckBox()
        {
            InitializeComponent();
        }

        private void CheckBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Themes.Thema.Default.Shema.Background),e.ClipRectangle);
            e.Graphics.
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
