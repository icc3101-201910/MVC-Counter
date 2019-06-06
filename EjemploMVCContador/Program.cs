using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace EjemploMVCContador
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
            Form1 form1 = new Form1();
            Contador contador = new Contador();
            Controlador controlador = new Controlador(form1, contador);
            Application.Run(form1);
        }
    }
}
