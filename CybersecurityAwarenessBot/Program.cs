using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cybersecurity Awareness Bot is Starting...");
            AudioGreeting.GreetWelcome();

            ConsoleUI.DisplayLogo();

            ConsoleUI.PrintHeader("Main Menu");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            
        }
    }
}

    

