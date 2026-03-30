using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    public class ChatBot
    {
        // Stores the user's name for personalised responses
        private readonly string _userName;

        // Constructor receives the user's name from Program.cs
        public ChatBot(string userName)
        {
            _userName = userName;
        }

        // Main conversation loop - runs until user types quit or exit
        public void Run()
        {
            ConsoleUI.PrintHeader("Chat Session Started");

            while (true)
            {
                string input = ConsoleUI.GetUserInput(_userName);

                // Validate the input first
                ValidationResult validation = InputValidator.Validate(input);
                if (!validation.IsValid)
                {
                    ConsoleUI.DisplayBotResponse(validation.ErrorMessage);
                    continue;
                }

                // Get a matched response from ResponseEngine
                string response = ResponseEngine.GetResponse(input);

                // Handle quit or exit
                if (response == "QUIT" || input.ToLower() == "quit" || input.ToLower() == "exit")
                {
                    ConsoleUI.PrintDivider();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n  Goodbye, {_userName}! Stay safe online.\n");
                    Console.ResetColor();
                    ConsoleUI.PrintDivider();
                    break;
                }

                // Use default response if no keyword matched
                if (response == null)
                {
                    ConsoleUI.DisplayBotResponse(InputValidator.DefaultResponse());
                    continue;
                }

                // Display the matched response
                ConsoleUI.DisplayBotResponse(response);
            }
        }
    }
}