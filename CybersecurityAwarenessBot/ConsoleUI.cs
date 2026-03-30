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
    }
}
