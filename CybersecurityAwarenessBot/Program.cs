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
            while (true)
            {

                input = ConsoleUI.GetUserInput(userName);

                // Skip empty input
                if (string.IsNullOrWhiteSpace(input))
                {
                    ConsoleUI.DisplayBotResponse("You did not type anything. Please enter a message.");
                    continue;
                }

                // Get response from ResponseEngine
                string response = ResponseEngine.GetResponse(input);

                // Handle quit
                if (response == "QUIT" || input.ToLower() == "quit" || input.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n  Goodbye, {userName}! Stay safe online.");
                    Console.ResetColor();
                    ConsoleUI.PrintDivider();
                    break;
                }

                // Handle no match found
                if (response == null)
                {
                    ConsoleUI.DisplayBotResponse("I did not quite understand that. Could you rephrase? (Type 'help' to see topics.)");
                    continue;
                }

                // Display the matched response
                ConsoleUI.DisplayBotResponse(response);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
            
            

