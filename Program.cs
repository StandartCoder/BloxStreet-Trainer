using DiscordRPC.Logging;
using DiscordRPC;
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
        public static DiscordRpcClient client;
        private static Timestamps since_open;

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

            Config.rpc = Config.getRPC();
            Config.username = Config.getUsername();
            settings.user.Text = Config.username;
            settings.rpc.Checked = Config.rpc;

            if (Config.rpc)
            {
                initRPC();
            }

            Application.Run(home);
        }

        public static void initRPC()
        {
            since_open = Timestamps.Now;

            client = new DiscordRpcClient("1243720827179110462");

            // Connect to the RPC
            client.Initialize();

            // Set the rich presence
            client.SetPresence(new RichPresence()
            {
                Details = "Main Menu",
                //State = "Main Menu",
                Timestamps = since_open,
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "Coded by StandartCoder",
                    SmallImageKey = "blox"
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = "Download Here", Url = "https://github.com/StandartCoder/BloxStreet-Trainer/releases/tag/latest"}
                }
            });
        }

        public static void changeRPCState(string state)
        {
            if (client == null)
                return;

            client.SetPresence(new RichPresence()
            {
                Details = state,
                //State = state,
                Timestamps = since_open,
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "Coded by StandartCoder",
                    SmallImageKey = "blox"
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = "Download Here", Url = "https://github.com/StandartCoder/BloxStreet-Trainer/releases/tag/latest"}
                }
            });
        }

        public static void closeRPC()
        {
            if (client == null)
                return;

            client.Dispose();
            client = null;
        }
    }
}
