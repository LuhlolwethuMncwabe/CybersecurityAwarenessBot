using System;
using System.Media;
using System.IO;
using System.Speech.Synthesis;

namespace CybersecurityAwarenessBot
{
    public static class AudioGreeting
    {
        public static void PlayGreeting(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.PlaySync();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"[Audio] {filePath} not found. Skipping audio greeting.");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Audio Error] {ex.Message}");
                Console.ResetColor();
            }
        }

        public static void SpeakGreeting(string message)
        {
            try
            {
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    synth.Volume = 100;
                    synth.Rate = 0;

                  

                    synth.SelectVoice("Microsoft Zira Desktop");
                    synth.Speak(message);

                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Speech Error] {ex.Message}");
                Console.ResetColor();
            }
        }

        public static void GreetWelcome()
        {
            string welcomeMessage = "Welcome to the Cybersecurity Awareness Bot. I'm here to help, you, keep safe online. ";

            Console.WriteLine(welcomeMessage);

            SpeakGreeting(welcomeMessage);


        }
    }
}
