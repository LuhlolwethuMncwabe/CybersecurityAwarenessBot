using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CybersecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Launch greeting
            Console.WriteLine("Cybersecurity Awareness Bot is Starting...");
            ConsoleUI.DisplayLogo();
            AudioGreeting.GreetWelcome();

            ConsoleUI.PrintHeader("Main Menu");

            // Get user name
            string userName = ConsoleUI.GetUserName();
            ConsoleUI.DisplayWelcome(userName);

            // Hand off to ChatBot class to handle the full conversation
            ChatBot bot = new ChatBot(userName);
            bot.Run();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}



