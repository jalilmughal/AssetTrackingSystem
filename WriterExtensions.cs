using System;

namespace AssetTrackingSystem
{
    public static class WriterExtensions
    {
        public static void WriteMessageInRed(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(input);
            Console.ResetColor();
        }
        public static void WriteMessageYellow(string input)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input);
            Console.ResetColor();
        }
    }
}
