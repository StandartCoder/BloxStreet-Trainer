using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloxStreet_Trainer
{
    internal class Config
    {
        public static string version = "0.9.7";
        public static string username = "";
        
        // check if newst version is installed
        
        public static void checkIfNewstVersion()
        {
            // do http request to get newst version
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            string newst_version = wc.DownloadString("https://pastebin.com/raw/rcjSEQ6g").Trim();

            if (newst_version != version)
            {
                MessageBox.Show("This version is outdated... Click OK to open download page.");
                System.Diagnostics.Process.Start("https://github.com/StandartCoder/BloxStreet-Trainer/releases");
                Application.Exit();
                Environment.Exit(0);
            }
        }

        public static void checkIfExists()
        {
            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet"))
            {
                string[] config = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\config.ini");
                if (config[0].Split('=')[1] != version)
                {
                    MessageBox.Show("The config version was outdated, we removed the whole config. Resetted lines.");
                    System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet", true);
                }
            }

            if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet"))
            { 
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet");
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines");

                // create config.ini with version and username
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\config.ini", "version=" + version + "\nusername=" + username);

                // create lines files introduction
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\introduction.txt", "");
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\cafe_test.txt", "");
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\register_test.txt", "");
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\passing_lrs.txt", "");

                // fill files with standard lines in Data.cs
                foreach (string line in Data.introduction_script)
                {
                    System.IO.File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\introduction.txt", line + "\n");
                }

                foreach (string line in Data.cafe_test_script)
                {
                    System.IO.File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\cafe_test.txt", line + "\n");
                }   

                foreach (string line in Data.register_test_script)
                {
                    System.IO.File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\register_test.txt", line + "\n");
                }

                foreach (string line in Data.passing_lrs_script)
                {
                    System.IO.File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\passing_lrs.txt", line + "\n");
                }
            }
        }

        public static bool changeUsername(string newName)
        {
            try
            {
                string[] config = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\config.ini");
                config[1] = "username=" + newName;
                System.IO.File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\config.ini", config);
            }
            catch
            {
                return false;
            }


            return true;
        }

        public static string getUsername()
        {
            string[] config = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\config.ini");
            return config[1].Split('=')[1];
        }

        public static List<string> getLines(string name)
        {
            string[] lines = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines\\" + name + ".txt");
            return lines.ToList();

        }
    }
}
