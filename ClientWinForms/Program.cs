using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static Form1 myMainForm = null;
        public static AddActionFrom mySecondForm = null;
        public static Settings mySettingsForm = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            myMainForm = new Form1();
            mySecondForm = new AddActionFrom();
            mySettingsForm = new Settings();

            Application.Run(myMainForm);
        }
    }
}
