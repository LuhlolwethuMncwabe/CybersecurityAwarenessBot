using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{
    public static class ResponseEngine
    {
        private static List<(string[] keywords, string response)> _responses
            = new List<(string[], string)>
        {
            (new[] { "how are you", "how r you" },
             "I am fully operational and ready to help you stay cyber-safe!"),

            (new[] { "hello", "hi", "hey" },
             "Hello! I am your Cybersecurity Awareness Bot. Type 'help' to see what I can do."),

            (new[] { "purpose", "what do you do", "your role" },
             "My purpose is to educate you on cybersecurity: password safety, phishing, and safe browsing."),

            (new[] { "what can i ask", "topics", "what can you help" },
             "You can ask me about:\n   - Password safety\n     - Phishing attacks\n   - Safe browsing\n   - Two-factor authentication (2FA)\n   - Data privacy"),

            (new[] { "password", "strong password", "password safety" },
             "PASSWORD SAFETY TIPS:\n   - Use at least 12 characters\n   - Mix uppercase, lowercase, numbers and symbols\n   - Never reuse passwords\n   - Use a password manager\n   - Enable two-factor authentication"),

            (new[] { "phishing", "scam email", "suspicious email" },
             "PHISHING AWARENESS:\n  - Do not click unknown links in emails\n     - Check the sender address carefully\n   - Legitimate companies never ask for your password via email\n   - Look for spelling mistakes and urgency tactics"),

            (new[] { "safe browsing", "browsing", "internet safety" },
             "SAFE BROWSING TIPS:\n   - Always look for HTTPS in the URL\n   - Avoid public Wi-Fi for sensitive tasks\n   - Keep your browser updated\n   - Do not download files from untrusted sources"),

            (new[] { "two factor", "2fa", "two-factor", "authentication" },
             "TWO-FACTOR AUTHENTICATION (2FA):\n   Even if someone steals your password, 2FA stops them.\n   Enable it on every account that offers it."),

            (new[] { "privacy", "data privacy", "personal data" },
             "DATA PRIVACY TIPS:\n   - Only share personal info on trusted sites\n   - Review app permissions regularly\n   - Use a VPN on public networks"),

            (new[] { "help", "menu", "options" },
             "AVAILABLE TOPICS:\n   password      - Password safety tips\n   phishing       - How to spot phishing\n   safe browsing  - Browse securely\n   2fa            - Two-factor authentication\n   privacy        - Data privacy tips\n   purpose        - What I do\n   quit / exit    - Exit the bot"),

            (new[] { "quit", "exit", "bye", "goodbye" },
             "QUIT"),
        };

        public static string GetResponse(string input)
        {
            string lower = input.ToLower().Trim();
            foreach (var entry in _responses)
            {
                foreach (var keyword in entry.keywords)
                {
                    if (lower.Contains(keyword))
                        return entry.response;
                }
            }
            return null;
        }
    }
}