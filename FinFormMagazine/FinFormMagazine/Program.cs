using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinFormMagazine
{
    static class Program
    {
        public static bool flag = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
           // Application.Run(new CasirForm());
        }
    }
}
