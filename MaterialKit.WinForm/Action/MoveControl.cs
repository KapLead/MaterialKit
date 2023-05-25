using System.Drawing;
using System.Windows.Forms;

namespace MaterialKit.WinForm.Action
{
    public class MoveControl
    {
        public bool IsMoving { get; private set; }
        private Control _parent = null;
        private Control[] _elements = null;
        private Point point;
        public MoveControl(Control parent, Control[] elements)
        {
            _parent = parent;
            _elements = elements;
            foreach (Control ctr in _elements)
            {
                ctr.MouseDown+= CtrOnMouseDown;
                ctr.MouseMove+= CtrOnMouseMove;
                ctr.MouseUp+= CtrOnMouseUp;
            }
        }

        private void CtrOnMouseUp(object sender, MouseEventArgs e)
        {
            IsMoving = false;
            point= Point.Empty;
        }

        private void CtrOnMouseMove(object sender, MouseEventArgs e)
        {
            if (IsMoving && _parent!=null)
            {
                _parent.Left +=e.X - point.X;
                _parent.Top +=e.Y - point.Y;
            }
        }

        private void CtrOnMouseDown(object sender, MouseEventArgs e)
        {
            if(IsMoving) return;
            IsMoving = true;
            point = e.Location;
        }
    }
}
