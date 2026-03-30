using System;
using System.Media;
using System.IO;

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
                    Console.WriteLine("[Audio] greeting.wav not found. Skipping voice greeting.");
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
    }
}
