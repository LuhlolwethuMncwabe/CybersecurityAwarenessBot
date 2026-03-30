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
           
            ConsoleUI.DisplayLogo();

            AudioGreeting.GreetWelcome();

            ConsoleUI.PrintHeader("Main Menu");


            string userName = ConsoleUI.GetUserName();
            ConsoleUI.DisplayWelcome(userName);


            ChatBot bot = new ChatBot(userName);
            bot.Run();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  Thank you for using the Cybersecurity Awareness Bot!");
            Console.WriteLine(" \n Remember to stay safe online. Goodbye!");
            Console.ResetColor();
            ConsoleUI.PrintDivider();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}



