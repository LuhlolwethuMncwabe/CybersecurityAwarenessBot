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
            ConsoleUI.DisplayLogo();
            AudioGreeting.GreetWelcome();

          
            ConsoleUI.PrintHeader("Main Menu");

            string userName = ConsoleUI.GetUserName();
            ConsoleUI.DisplayWelcome(userName);

            string input = "";
            while (input.ToLower() != "quit" && input.ToLower() != "exit")
            {
                input = ConsoleUI.GetUserInput(userName);
                if (input.ToLower() == "help")
                {
                    ConsoleUI.DisplayBotResponse("I can help you with tips on staying safe online!");
                }
                else if (input.ToLower() != "quit" && input.ToLower() != "exit")
                {
                    ConsoleUI.DisplayBotResponse("Sorry, I don't understand that command.");
                }
            }
            Console.WriteLine("\nThank you for using the Cybersecurity Awareness Bot. Stay safe online!");
            Console.ReadKey();
            
        }
    }
}

    

