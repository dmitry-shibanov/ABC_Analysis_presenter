using ABC_Analysis_presenter.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Analysis_presenter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
    
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form mainFrom = new NavigationForm();
            mainFrom.FormBorderStyle = FormBorderStyle.FixedSingle;
            Application.Run(mainFrom);
        }
    }
}
