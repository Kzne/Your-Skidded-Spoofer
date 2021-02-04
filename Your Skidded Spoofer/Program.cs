using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Your_Skidded_Spoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu:
            //Header
            Console.ForegroundColor = ConsoleColor.DarkRed;
            String Header = "  ██████  ██ ▄█▀ ██▓▓█████▄      ██████  ██▓███   ▒█████   ▒█████    █████▒\n▒██    ▒  ██▄█▒ ▓██▒▒██▀ ██▌   ▒██    ▒ ▓██░  ██▒▒██▒  ██▒▒██▒  ██▒▓██   ▒ \n░ ▓██▄   ▓███▄░ ▒██▒░██   █▌   ░ ▓██▄   ▓██░ ██▓▒▒██░  ██▒▒██░  ██▒▒████ ░ \n  ▒   ██▒▓██ █▄ ░██░░▓█▄   ▌     ▒   ██▒▒██▄█▓▒ ▒▒██   ██░▒██   ██░░▓█▒  ░ \n▒██████▒▒▒██▒ █▄░██░░▒████▓    ▒██████▒▒▒██▒ ░  ░░ ████▓▒░░ ████▓▒░░▒█░    \n▒ ▒▓▒ ▒ ░▒ ▒▒ ▓▒░▓   ▒▒▓  ▒    ▒ ▒▓▒ ▒ ░▒▓▒░ ░  ░░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒ ░    \n░ ░▒  ░ ░░ ░▒ ▒░ ▒ ░ ░ ▒  ▒    ░ ░▒  ░ ░░▒ ░       ░ ▒ ▒░   ░ ▒ ▒░  ░      \n░  ░  ░  ░ ░░ ░  ▒ ░ ░ ░  ░    ░  ░  ░  ░░       ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░    \n      ░  ░  ░    ░     ░             ░               ░ ░      ░ ░          \n                     ░                                                     ";

            Console.Title = "Skid Spoofer | guap#4132";
            Console.WriteLine(Header);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Made by Guap");
            Console.WriteLine();
            Console.WriteLine(" 1) Spoof");
            Console.WriteLine();
            Console.WriteLine(" 2) Clean");
            Console.WriteLine();
            Console.WriteLine(" 3) Discord");
            Console.WriteLine();
            Console.Write(" > ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                MessageBox.Show("Spoofing");
                Spoofer.Spoof();
                MessageBox.Show("Spoofed");
                goto Menu;
            }
            else if (option == "2")
            {
                MessageBox.Show("Cleaning");
                Spoofer.Clean();
                MessageBox.Show("Cleaned");
                goto Menu;
            }
            else if (option == "3")
            {
                Console.Clear();
                Process.Start("https://discord.gg/5qc53pS");
                goto Menu;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong Button Retard");
                Thread.Sleep(2000);
                Console.Clear();
                goto Menu;
            }
        }
    }
}
