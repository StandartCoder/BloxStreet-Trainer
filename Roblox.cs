using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BloxStreet_Trainer
{
    internal class Roblox
    {
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetMessageExtraInfo();

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const int SW_RESTORE = 9;
        private const int KEYEVENTF_KEYUP = 0x0002;
        
        const byte VK_RETURN = 0x0D;

        public static void Chat(String message)
        {
            Type(message);
            SendCharacter((char)VK_RETURN);
        }

        public static void Type(String message)
        {
            string robloxWindowTitle = "Roblox";

            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            if (processes.Length == 0)
            {
                return;
            }

            Process robloxProcess = null;
            foreach (var process in processes)
            {
                if (process.MainWindowTitle.Contains(robloxWindowTitle))
                {
                    robloxProcess = process;
                    break;
                }
            }

            if (robloxProcess == null)
            {
                return;
            }

            IntPtr hWnd = robloxProcess.MainWindowHandle;
            ShowWindow(hWnd, SW_RESTORE);
            BringWindowToTop(hWnd);
            SetForegroundWindow(hWnd);

            SendCharacter('o');
            SendKeys.SendWait(message);
        }

        private static void SendCharacter(char character)
        {
            byte vk = (byte)character;
            byte scanCode = (byte)MapVirtualKey(vk, 0);

            keybd_event(vk, scanCode, 0, GetMessageExtraInfo());
            keybd_event(vk, scanCode, KEYEVENTF_KEYUP, GetMessageExtraInfo());

            Thread.Sleep(50);
        }
    }
}
