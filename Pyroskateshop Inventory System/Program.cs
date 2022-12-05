using System;
using System.Windows.Forms;

namespace Pyroskateshop_Inventory_System
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new InicioDeSesion());
            Application.Run(new InicioDeSesion());
        }
    }
}
