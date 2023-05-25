using System;
using System.Windows.Forms;
using MaterialKit.WinForm.Themes;

namespace MaterialKit.WinForm.Test
{
    internal static class Program
    {
        [STAThread] static void Main()
        {
            Thema.Initialization(ColorSheme.Blue);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
