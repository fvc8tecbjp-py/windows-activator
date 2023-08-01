using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{   
    static void menuBanner()
    {
        string banner = @"

     █     █░ ██▓ ███▄    █ ▓█████▄  ▒█████   █     █░  ██████     ▄▄▄       ▄████▄  ▄▄▄█████▓ ██▓ ██▒   █▓ ▄▄▄     ▄▄▄█████▓ ▒█████   ██▀███  
    ▓█░ █ ░█░▓██▒ ██ ▀█   █ ▒██▀ ██▌▒██▒  ██▒▓█░ █ ░█░▒██    ▒    ▒████▄    ▒██▀ ▀█  ▓  ██▒ ▓▒▓██▒▓██░   █▒▒████▄   ▓  ██▒ ▓▒▒██▒  ██▒▓██ ▒ ██▒
    ▒█░ █ ░█ ▒██▒▓██  ▀█ ██▒░██   █▌▒██░  ██▒▒█░ █ ░█ ░ ▓██▄      ▒██  ▀█▄  ▒▓█    ▄ ▒ ▓██░ ▒░▒██▒ ▓██  █▒░▒██  ▀█▄ ▒ ▓██░ ▒░▒██░  ██▒▓██ ░▄█ ▒
    ░█░ █ ░█ ░██░▓██▒  ▐▌██▒░▓█▄   ▌▒██   ██░░█░ █ ░█   ▒   ██▒   ░██▄▄▄▄██ ▒▓▓▄ ▄██▒░ ▓██▓ ░ ░██░  ▒██ █░░░██▄▄▄▄██░ ▓██▓ ░ ▒██   ██░▒██▀▀█▄  
    ░░██▒██▓ ░██░▒██░   ▓██░░▒████▓ ░ ████▓▒░░░██▒██▓ ▒██████▒▒    ▓█   ▓██▒▒ ▓███▀ ░  ▒██▒ ░ ░██░   ▒▀█░   ▓█   ▓██▒ ▒██▒ ░ ░ ████▓▒░░██▓ ▒██▒
    ░ ▓░▒ ▒  ░▓  ░ ▒░   ▒ ▒  ▒▒▓  ▒ ░ ▒░▒░▒░ ░ ▓░▒ ▒  ▒ ▒▓▒ ▒ ░    ▒▒   ▓▒█░░ ░▒ ▒  ░  ▒ ░░   ░▓     ░ ▐░   ▒▒   ▓▒█░ ▒ ░░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░
      ▒ ░ ░   ▒ ░░ ░░   ░ ▒░ ░ ▒  ▒   ░ ▒ ▒░   ▒ ░ ░  ░ ░▒  ░ ░     ▒   ▒▒ ░  ░  ▒       ░     ▒ ░   ░ ░░    ▒   ▒▒ ░   ░      ░ ▒ ▒░   ░▒ ░ ▒░
      ░   ░   ▒ ░   ░   ░ ░  ░ ░  ░ ░ ░ ░ ▒    ░   ░  ░  ░  ░       ░   ▒   ░          ░       ▒ ░     ░░    ░   ▒    ░      ░ ░ ░ ▒    ░░   ░ 
        ░     ░           ░    ░        ░ ░      ░          ░           ░  ░░ ░                ░        ░        ░  ░            ░ ░     ░     
         ░                                              ░                          ░                                       
                                                                                                 by https://github.com/fvc8tecbjp-py
";
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(banner);
        Console.ResetColor();
    }
    static void menuOptions()
    {
        string options = @"    Select your windows version
    [1] Home Single Language    [4] Pro                     [7] Education       [10] Pro Education N    [13] Enterprise G N     [16] Enterprise LTSC 2019
    [2] Home Edition            [5] Workstations            [8] Education N     [11] Enterprise         [14] Enterprise N       [17] Enterprise N LTSC 2019
    [3] Home                    [6] Pro for Workstations    [9] Pro Education   [12] Enterprise G       [15] Enterprise S       [18] Enterprise LTSB 2016
";
        Console.WriteLine(options);
    }
    static void serialPrint(int variation)
    {
        switch (variation)
        {
            case 1:
                Console.WriteLine("    [1] NTRHT-XTHTG-GBWCG-4MTMP-HH64C    [2] 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH   [3] BT79Q-G7N6G-PGBYW-4YWX6-6F4BT");
                break;
            case 2:
                Console.WriteLine("    [1] TX9XD-98N7V-6WMQ6-BX7FG-H8Q99");
                break;
            case 3:
                Console.WriteLine("    [1] TX9XD-98N7V-6WMQ6-BX7FG-H8Q99    [2] YTMG3-N6DKC-DKB77-7M9GH-8HVX7");
                break;
            case 4:
                Console.WriteLine("    [1] VK7JG-NPHTM-C97JM-9MPGT-3V66T    [2] W269N-WFGWX-YVC9B-4J6C9-T83GX   [3] NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J");
                break;
            case 5:
                Console.WriteLine("    [1] NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J");
                break;
            case 6:
                Console.WriteLine("    [1] NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J");
                break;
            case 7:
                Console.WriteLine("    [1]  NW6C2-QMPVW-D7KKK-3GKT6-VCFB2");
                break;
            case 8:
                Console.WriteLine("    [1] 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ");
                break;
            case 9:
                Console.WriteLine("    [1] 6TP4R-GNPTD-KYYHQ-7B7DP-J447Y");
                break;
            case 10:
                Console.WriteLine("    [1] YVWGF-BXNMC-HTQYQ-CPQ99-66QFC");
                break;
            case 11:
                Console.WriteLine("    [1] NPPR9-FWDCX-D2C8J-H872K-2YT43");
                break;
            case 12:
                Console.WriteLine("    [1] YYVX9-NTFWV-6MDM3-9PT4T-4M68B");
                break;
            case 13:
                Console.WriteLine("    [1] 44RPN-FTY23-9VTTB-MP9BX-T84FV");
                break;
            case 14:
                Console.WriteLine("    [1] DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4");
                break;
            case 15:
                Console.WriteLine("    [1] FWN7H-PF93Q-4GGP8-M8RF3-MDWWW");
                break;
            case 16:
                Console.WriteLine("    [1] M7XTQ-FN8P6-TTKYV-9D4CC-J462D");
                break;
            case 17:
                Console.WriteLine("    [1] 92NFX-8DJQP-P6BBQ-THF9C-7CG2H");
                break;
            case 18:
                Console.WriteLine("    [1] DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ");
                break;
        }
        Console.WriteLine();
    }
    static bool checkSerial(int version, int serial)
    {
        switch (version)
        {
            case 1:
                if(serial < 1 || serial > 3)
                {
                    return false;
                }
                break;
            case 2:
                if(serial != 1)
                {
                    return false;
                }
                break;
            case 3:
                if (serial < 1 || serial > 2)
                {
                    return false;
                }
                break;
            case 4:
                if (serial < 1 || serial > 3)
                {
                    return false;
                }
                break;
            case 5:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 6:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 7:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 8:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 9:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 10:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 11:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 12:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 13:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 14:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 15:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 16:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 17:
                if (serial != 1)
                {
                    return false;
                }
                break;
            case 18:
                if (serial != 1)
                {
                    return false;
                }
                break;
        }
        return true;
    }
    static string runBat(string command)
    {
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.Arguments = $"/c \"{command}\"";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;

        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        return output;
    }
    static void input()
    {
        Console.Write("    Option: ");
    }
    static void activate(int version, int serial)
    {
        version -= 1;
        serial -= 1;
        string[][] codes = new string[18][];

        codes[0] = new string[3] { "NTRHT-XTHTG-GBWCG-4MTMP-HH64C", "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH", "BT79Q-G7N6G-PGBYW-4YWX6-6F4BT" };
        codes[1] = new string[1] { "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99" };
        codes[2] = new string[2] { "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99", "YTMG3-N6DKC-DKB77-7M9GH-8HVX7" };
        codes[3] = new string[3] { "VK7JG-NPHTM-C97JM-9MPGT-3V66T", "W269N-WFGWX-YVC9B-4J6C9-T83GX", "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J" };
        codes[4] = new string[1] { "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J"};
        codes[5] = new string[1] {"NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J"};
        codes[6] = new string[1] {"NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"};
        codes[7] = new string[1] {"2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"};
        codes[8] = new string[1] {"6TP4R-GNPTD-KYYHQ-7B7DP-J447Y"};
        codes[9] = new string[1] {"YVWGF-BXNMC-HTQYQ-CPQ99-66QFC"};
        codes[10] = new string[1] {"NPPR9-FWDCX-D2C8J-H872K-2YT43"};
        codes[11] = new string[1] {"YYVX9-NTFWV-6MDM3-9PT4T-4M68B"};
        codes[12] = new string[1] {"44RPN-FTY23-9VTTB-MP9BX-T84FV"};
        codes[13] = new string[1] {"DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"};
        codes[14] = new string[1] {"FWN7H-PF93Q-4GGP8-M8RF3-MDWWW"};
        codes[15] = new string[1] {"M7XTQ-FN8P6-TTKYV-9D4CC-J462D"};
        codes[16] = new string[1] {"92NFX-8DJQP-P6BBQ-THF9C-7CG2H"};
        codes[17] = new string[1] {"DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ"};

        runBat("cscript \"C:\\Windows\\System32\\slmgr.vbs\" /ipk " + codes[version][serial]);
        runBat("cscript \"C:\\Windows\\System32\\slmgr.vbs\" /skms kms.lotro.cc");
        runBat("cscript \"C:\\Windows\\System32\\slmgr.vbs\" /ato");
    }
    static void Main()
    {
        Console.Clear();

        Console.WindowWidth = 160;
        Console.WindowHeight = 22;

        menuBanner();

        Console.ForegroundColor = ConsoleColor.Yellow;
        menuOptions();

        int version = 0;
        try
        {
            input();
            version = int.Parse(Console.ReadLine());
            if (version < 1 || version > 18)
            {
                Main();
            }
        }
        catch (FormatException)
        {
            Main();
        }

        Console.Clear();
        Console.WindowHeight = 19;

        menuBanner();

        Console.ForegroundColor = ConsoleColor.Yellow;
        serialPrint(version);

        int serial = 0;
        try
        {
            input();
            serial = int.Parse(Console.ReadLine());
            if (!checkSerial(version, serial))
            {
                Main();
            } else
            {
                activate(version, serial);
            }
        }
        catch (FormatException)
        {
            Main();
        }

        Console.Clear();
        Console.WindowHeight = 18;

        menuBanner();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("    Done! If the activation didn't work properly, use another serial!");
        Console.WriteLine("    Press any key to exit!");

        Console.ResetColor();
        Console.ReadKey();
    }
}