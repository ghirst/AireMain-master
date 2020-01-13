using System;
using System.Collections.Generic;
using System.Text;

namespace AireMain.Classes
{
    public class colourMagic
    { 
        public static void ohLookColorMagic(string style)
        {
            if (style != "AL")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                //Client Colours (Aire Logic...)
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
