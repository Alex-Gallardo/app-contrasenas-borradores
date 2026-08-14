using SistemaRecibos.Formularios;
using System;
using System.Windows.Forms;

namespace SistemaRecibos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInicioSesion());
            //   Application.Run(new FrmPrincipal());
            //ConexionSAP.Open();
        }
    }
}
