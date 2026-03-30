using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    public static class InputValidator
    {
 
        public static ValidationResult Validate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new ValidationResult(false, "You did not type anything. Please enter a message.");

            if (input.Trim().Length < 2)
                return new ValidationResult(false, "Your input is too short. Could you rephrase?");

            if (input.Length > 300)
                return new ValidationResult(false, "That message is too long. Please keep it under 300 characters.");

            return new ValidationResult(true, null);
        }

        
        public static string DefaultResponse()
        {
            return "I did not quite understand that. Could you rephrase? (Type 'help' to see topics.)";
        }
    }


    public class ValidationResult
    {
        public bool IsValid { get; }
        public string ErrorMessage { get; }

        public ValidationResult(bool isValid, string errorMessage)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }
    }
}