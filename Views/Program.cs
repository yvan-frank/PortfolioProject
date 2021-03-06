using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Views.Controls;
using Views.HomeForm.HomeAdmin;
using Views.HomeForm.HomeAdmin.FormAdmin;
using Views.HomeForm.HomeMembreProjet;
using Views.HomeForm.HomeMembreProjet.Form;
using Views.LoginForm;

namespace Views
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminForm());
        }
    }
}
