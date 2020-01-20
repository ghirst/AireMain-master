using System;

namespace AireMain.Classes
{
    public class ColourMagic
    {
        public static void OhLookColorMagic(string style)
        {
            switch (style.ToLower())
            {
                case "al":  //int is obviously quicker but this is easier to read!
                    //Client Colours (AL...)
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "ohno":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "phoenix":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}