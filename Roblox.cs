using System;
using System.Collections.Generic;
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

        public static void Focus()
        {
            string robloxWindowTitle = "Roblox";

            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            if (processes.Length == 0)
            {
                Console.WriteLine("Roblox process not found.");
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
                Console.WriteLine("Roblox window not found.");
                return;
            }

            IntPtr hWnd = robloxProcess.MainWindowHandle;
            ShowWindow(hWnd, SW_RESTORE);
            BringWindowToTop(hWnd);
            SetForegroundWindow(hWnd);
            Thread.Sleep(200); // Added delay to ensure the window is focused
        }

        public static void focusBack()
        {
            SetForegroundWindow(Process.GetCurrentProcess().MainWindowHandle);
            Thread.Sleep(200); // Added delay to ensure the focus is returned
        }

        public static void OldChat(String message)
        {
            Type(message);
            SendCharacter((char)VK_RETURN);
            focusBack();
        }

        public static void Chat(String message)
        {
            try
            {
                Focus();
                Clipboard.SetText(message);
                Thread.Sleep(100); // Ensure clipboard has enough time to set text

                SendCharacter('o');
                Thread.Sleep(100); // Small delay before sending paste command
                SendKeys.SendWait("^v");
                Thread.Sleep(100); // Ensure paste operation is complete
                SendCharacter((char)VK_RETURN);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Chat: " + ex.Message);
            }
            finally
            {
                focusBack();
            }
        }

        public static void ChatMany(List<string> messages)
        {
            try
            {
                Focus();

                foreach (var message in messages)
                {
                    Clipboard.SetText(message);
                    Thread.Sleep(100); // Ensure clipboard has enough time to set text

                    SendCharacter('o');
                    Thread.Sleep(100); // Small delay before sending paste command
                    SendKeys.SendWait("^v");
                    Thread.Sleep(100); // Ensure paste operation is complete
                    SendCharacter((char)VK_RETURN);
                    Thread.Sleep(200); // Delay between messages
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in ChatMany: " + ex.Message);
            }
            finally
            {
                focusBack();
            }
        }

        public static void Type(String message)
        {
            Focus();

            SendCharacter('o');
            Thread.Sleep(100); // Ensure the 'o' character is sent
            SendKeys.SendWait(message);
        }

        private static void SendCharacter(char character)
        {
            byte vk = (byte)character;
            byte scanCode = (byte)MapVirtualKey(vk, 0);

            keybd_event(vk, scanCode, 0, GetMessageExtraInfo());
            keybd_event(vk, scanCode, KEYEVENTF_KEYUP, GetMessageExtraInfo());

            Thread.Sleep(50); // Delay to ensure the key event is processed
        }
    }
}
