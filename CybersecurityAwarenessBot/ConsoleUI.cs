using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CybersecurityAwarenessBot
{
    public static class ConsoleUI
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
╔═╗┬ ┬┌┐ ┌─┐┬─┐  ╔═╗┌─┐┌─┐┬ ┬┬─┐┬┌┬┐┬ ┬  
║  └┬┘├┴┐├┤ ├┬┘  ╚═╗├┤ │  │ │├┬┘│ │ └┬┘  
╚═╝ ┴ └─┘└─┘┴└─  ╚═╝└─┘└─┘└─┘┴└─┴ ┴  ┴                                                                                                                                        
     [KEEPING YOU SAFE ONLINE!]                                                                                                                                                         
            ");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintDivider();
            Console.ResetColor();
        }

        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  " + new string('-', 60));
            Console.ResetColor();
        }

        public static void PrintHeader(string title)
        {
            PrintDivider();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  [ " + title.ToUpper() + " ]");
            PrintDivider();
            Console.ResetColor();


        }
        public static string GetUserName()
        {
            string name = "";
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n  Enter your name: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Name cannot be empty. Please try again.");
                }
            }
            Console.ResetColor();
            return name.Trim();
        }

        public static void DisplayWelcome(string userName)
        {
            PrintDivider();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n  Welcome, {userName}! I am your Cybersecurity Awareness Bot.");
            Console.WriteLine("  I am here to help you stay safe online.\n");
            PrintDivider();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n  Type 'help' to see what I can assist you with.");
            Console.WriteLine("  Type 'quit' or 'exit' to leave.\n");
            Console.ResetColor();
        }

        public static void DisplayBotResponse(string response)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\n  Bot: ");
            Console.ResetColor();
            Console.WriteLine(response);
            Console.WriteLine();
        }

        public static string GetUserInput(string userName)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"  {userName}: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }
    }
}
