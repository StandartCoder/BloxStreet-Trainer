using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public static Settings settings;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Config.checkIfNewstVersion();
            Config.checkIfExists();

            string[] phases = { "introduction", "cafe_test", "register_test", "passing_lrs" };
            foreach (string phase in phases)
            {
                List<string> lines = Config.getLines(phase);

                if (phase == "introduction")
                {
                    Data.introduction_script = lines;
                }
                else if (phase == "cafe_test")
                {
                    Data.cafe_test_script = lines;
                }
                else if (phase == "register_test")
                {
                    Data.register_test_script = lines;
                }
                else if (phase == "passing_lrs")
                {
                    Data.passing_lrs_script = lines;
                }
            }

            home = new Home();
            time = new Time();
            three = new Three();
            training = new Training();
            settings = new Settings();

            home.version.Text = "Version: " + Config.version;
            time.version.Text = "Version: " + Config.version;
            three.version.Text = "Version: " + Config.version;
            training.version.Text = "Version: " + Config.version;
            settings.version.Text = "Version: " + Config.version;

            Config.username = Config.getUsername();
            settings.user.Text = Config.username;

            Application.Run(home);
        }

        
    }
}
