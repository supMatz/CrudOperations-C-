using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        public struct sStruct
        {
            public int Index;
            public string Content;
        }

        public static List<sStruct> list = new List<sStruct>();
    }
}
