using System;
using System.Collections.Generic;
using System.Text;

namespace AireMain.Classes
{
    public class colourMagic
    {
        public static void ohLookColorMagic(string style)
        { 
            switch (style.ToLower())
            {
                case "airelogic":  //int is obviously quicker but this is easier to read! 
                    //Client Colours (Aire Logic...)
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "ohno":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }  
        }
    }
}
