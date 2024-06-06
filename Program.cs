using System;
using System.Windows.Forms;

namespace Computer_Advance__WF
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Data + "\n" + ex.TargetSite.DeclaringType.FullName);
            }
        }
    }
}
