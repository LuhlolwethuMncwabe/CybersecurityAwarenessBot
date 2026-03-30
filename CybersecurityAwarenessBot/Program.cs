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


                ValidationResult validation = InputValidator.Validate(input);
                if (!validation.IsValid)
                {
                    ConsoleUI.DisplayBotResponse(validation.ErrorMessage);
                    continue;
                }

                string response = ResponseEngine.GetResponse(input);

                
                if (response == "QUIT" || input.ToLower() == "quit" || input.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n  Goodbye, {userName}! Stay safe online.");
                    Console.ResetColor();
                    ConsoleUI.PrintDivider();
                    break;
                }


                if (response == null)
                {
                    ConsoleUI.DisplayBotResponse(InputValidator.DefaultResponse());
                    continue;
                }

                ConsoleUI.DisplayBotResponse(response);
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
            
            

