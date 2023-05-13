using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iniciosesion_3int
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación con las listas creadas con el primer dato quemado.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
