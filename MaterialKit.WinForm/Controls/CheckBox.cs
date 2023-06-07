using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MaterialKit.WinForm.Annotations;
using MaterialKit.WinForm.Themes;

namespace MaterialKit.WinForm.Controls
{
    public partial class CheckBox : UserControl, INotifyPropertyChanged
    {
        private bool _isCheck = false;
        private FontStyle _style = FontStyle.Black;
        private TypeColor _background = TypeColor.Background;
        private TypeColor _foreground = TypeColor.Foreground;
        private string _text = "KitCheckBox";
        private FontSize _fontSize;
        private StringAlignment _alignment = StringAlignment.Far;
        private StringAlignment _lineAlignment = StringAlignment.Far;
        private TypeColor _accept = TypeColor.Accept;

        [Category("Kit")]
        public TypeColor Background {
            get => _background;
            set
            {
                if (value == _background) return;
                _background = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")]
        public TypeColor Foreground {
            get => _foreground;
            set
            {
                if (value == _foreground) return;
                _foreground = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")]
        public TypeColor Accept {
            get => _accept;
            set
            {
                if (value == _accept) return;
                _accept = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")]
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

        [Category("Kit")]
        public FontSize FontSize {
            get => _fontSize;
            set
            {
                if (value == _fontSize) return;
                _fontSize = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")]
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

        [Category("Kit")]
        public string Title {
            get => _text;
            set
            {
                if (value == _text) return;
                _text = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")]
        public StringAlignment Alignment {
            get => _alignment;
            set
            {
                if (value == _alignment) return;
                _alignment = value;
                Invalidate();
                OnPropertyChanged();
            }
        }

        [Category("Kit")]
        public StringAlignment LineAlignment {
            get => _lineAlignment;
            set
            {
                if (value == _lineAlignment) return;
                _lineAlignment = value;
                Invalidate();
                OnPropertyChanged();
            }
        }
        public StringFormat TextAlignment { get;set; }

    public CheckBox()
        {
            InitializeComponent();
            Resize+= OnInvalidate;
        }

        private void OnInvalidate(object sender, EventArgs e)
        {
            Invalidate(new Rectangle(Point.Empty,ClientSize));
        }

        private void CheckBox_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.FillRectangle(Background.ToSolidBrush(),e.ClipRectangle);
        
                Rectangle rect = new Rectangle(1, 1, 18, 18);
                int cx = rect.Width / 2, cy = rect.Height / 2;
                if (IsCheck)
                {
                    e.Graphics.FillRectangle(Accept.ToSolidBrush(),rect);
                    e.Graphics.DrawLine(Background.ToPen(2), rect.X + 7, rect.Y+12, rect.X + 3, rect.Y+8);
                    e.Graphics.DrawLine(Background.ToPen(2), rect.X + 7, rect.Y+12, rect.X+14,rect.Y+5);
                }
                Font font = Style.ToFont(FontSize) ?? new Font("Arial", 20.75f);
                e.Graphics.DrawString(Title, font, Foreground.ToSolidBrush(), 
                    new RectangleF(20,0,ClientSize.Width-20,ClientSize.Height)
                    , new StringFormat{Alignment = Alignment, LineAlignment = LineAlignment }  
                    );
            }
            catch (Exception exception)
            {
                
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
