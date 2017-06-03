using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProdanBackup
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string processo = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcessesByName(processo).Length > 1)
            {
                MessageBox.Show("Não é possível abrir duas instâncias deste programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmBackup());
            }
        }
    }
}
