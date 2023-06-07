using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using MaterialKit.WinForm.Annotations;
using System.Drawing;
using MaterialKit.WinForm.Themes;

namespace MaterialKit.WinForm.Controls
{
    public partial class Label : UserControl, INotifyPropertyChanged
    {
        private string _text="KitLabel";
        private FontSize _fontSize;
        private StringAlignment _alignment = StringAlignment.Center;
        private StringAlignment _lineAlignment = StringAlignment.Center;
        private FontStyle _style = FontStyle.Black;
        private TypeColor _background = TypeColor.Background;
        private TypeColor _foreground = TypeColor.Foreground;
        private TypeColor _accept = TypeColor.Accept;
        private bool _showShadow = true;

        [Category("Kit")] public override string Text {
            get => _text;
            set
            {
                if (value == _text) return;
                _text = value;
                Invalidate();
                OnPropertyChanged();
            }
        }
 
        [Category("Kit")] public TypeColor Background
        {
            get => _background;
            set
            {
                if (value == _background) return;
                _background = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")] public TypeColor Foreground
        {
            get => _foreground;
            set
            {
                if (value == _foreground) return;
                _foreground = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")] public TypeColor Accept
        {
            get => _accept;
            set
            {
                if (value == _accept) return;
                _accept = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")] public FontStyle Style
        {
            get => _style;
            set
            {
                if (value == _style) return;
                _style = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")] public FontSize FontSize
        {
            get => _fontSize;
            set
            {
                if (value == _fontSize) return;
                _fontSize = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")] public StringAlignment Alignment
        {
            get => _alignment;
            set
            {
                if (value == _alignment) return;
                _alignment = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")] public StringAlignment LineAlignment
        {
            get => _lineAlignment;
            set
            {
                if (value == _lineAlignment) return;
                _lineAlignment = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")] public bool ShadowShow {
            get => _showShadow;
            set
            {
                if (value == _showShadow) return;
                _showShadow = value;
                OnPropertyChanged();
            }
        }

        private Color _shadow;
        private Size _shadowAlign = new Size(2, 2);

        [Category("Kit")]
        public Color ShadowColor
        {
            get => _shadow;
            set
            {
                if (value == _shadow) return;
                _shadow = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")]
        public Size ShadowAlign
        {
            get => _shadowAlign;
            set
            {
                if(_shadowAlign == value) return;
                _shadowAlign = value;
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

        private void Label_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Background.ToSolidBrush(), e.ClipRectangle);
            Font font = Style.ToFont(FontSize);
            if(ShadowShow)
                e.Graphics.DrawString(Text, font, new SolidBrush(ShadowColor),
                    new RectangleF(2, 2, ClientSize.Width - 2, ClientSize.Height-2), new StringFormat
                    {
                        Alignment = Alignment,
                        LineAlignment = LineAlignment
                    }
                );

            e.Graphics.DrawString(Text,font, Foreground.ToSolidBrush(),
                   e.ClipRectangle, new StringFormat
                    {
                        Alignment = Alignment, 
                        LineAlignment = LineAlignment 
                    }  
                );
        }
    }
}
