using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace SQL_CE_Test
{
    static class Program
    {       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}