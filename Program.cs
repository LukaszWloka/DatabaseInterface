using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseInterface
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

            //Show first form and start the message loop
            try
            {
                (new Form1()).Show();
                Application.Run(); // needed, otherwise app closes immediately
            }
            catch(FirebirdSql.Data.FirebirdClient.FbException)
            {
                MessageBox.Show(@"Please be sure that database is under D:\dokumenty\StreamsoftEmployees.fdb and in Firebird there is a User: Stream1 with password Pass123");
            }
        }
    }
}
