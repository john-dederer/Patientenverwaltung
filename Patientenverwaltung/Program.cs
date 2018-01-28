using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenverwaltung
{
    static class Program
    {
        public static bool OpenMainFormOnClose { get; set; }
        public static Doctor Doctor { get; set; }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenMainFormOnClose = false;

            Application.Run(new Login());

            if (OpenMainFormOnClose)
            {
               Application.Run(new Main(Doctor)); 
            }
        }
    }
}
