using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Realizo la apertura del formulario para validar el login
            // esta tarea es previa al inicio de la aplicacion            
            /*FrmAcceso acceso = new FrmAcceso();
            acceso.ShowDialog();*/

            // Si el login es correcto, procedo con la apetura normal
            // de la aplicacion            
            //if (acceso.DialogResult == DialogResult.OK)
                Application.Run(new FrmPrincipal());
        }
    }
}
