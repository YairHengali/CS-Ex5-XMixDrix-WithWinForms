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
            Application.Run(new XMixDrix());
        }
    }
    /*
    public class Program
    {
        public static void Main()
        {


            //SettingsDialog gameSettings = new SettingsDialog();
            //gameSettings.ShowDialog();
            UserInterface gameInterface = new UserInterface();
            gameInterface.Start();
        }
    }*/
}
