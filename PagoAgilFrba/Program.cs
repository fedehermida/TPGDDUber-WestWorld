﻿using System;
using System.Windows.Forms;

namespace PagoAgilFrba
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
            // Application.Run(new AbmRol.Form1()); leo pajero no tenias que commitear esto
            Application.Run(new Login());
        }
    }
}
