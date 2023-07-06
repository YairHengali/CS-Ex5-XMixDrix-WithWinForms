using UI;
using System.Windows.Forms;
using System;

namespace Main
{
    static class Program
    {   
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormXMixDrix());
        }
    }
}
