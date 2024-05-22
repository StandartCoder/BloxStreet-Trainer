using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloxStreet_Trainer
{

    internal static class Program
    {
        public static Home home;
        public static Time time;
        public static Three three;
        public static Training training;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            home = new Home();
            time = new Time();
            three = new Three();
            training = new Training();

            Application.Run(home);
        }

        
    }
}
