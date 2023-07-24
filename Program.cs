using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroLibrary
{
    
    internal static class Program
    {
        public static String[] whoami = new string[3];
        public static string[] whoamitemp= new string[3];
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new MemberDetails().Show();
            Application.Run();
        }
    }
}
