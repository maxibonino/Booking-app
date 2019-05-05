using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string LevelPrivelegies = "";
        public static string ConnectionString = "Data Source=Morpheus-PC;Initial Catalog=Booking;Integrated Security=True";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LogIn());
            Application.Run(new Form1());
        }
    }
}
