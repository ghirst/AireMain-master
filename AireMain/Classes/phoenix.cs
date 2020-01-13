using System;
using System.Collections.Generic;
using System.Text;

namespace AireMain.Classes
{
    public class cmdImgs
    {
        internal static string PhoenixIcon()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            var phoenix = "";

            phoenix += @" .\\            //." + Environment.NewLine;
            phoenix += @" . \ \          / /." + Environment.NewLine;
            phoenix += @" .\  ,\     /` /,.-" + Environment.NewLine;
            phoenix += @"  -.   \  /'/ /  ." + Environment.NewLine;
            phoenix += @"  ` -   `-'  \  -" + Environment.NewLine;
            phoenix += @"    '.       /.\`" + Environment.NewLine;
            phoenix += @"       -    .-" + Environment.NewLine;
            phoenix += @"       :`//.'" + Environment.NewLine;
            phoenix += @"       .`.'" + Environment.NewLine;
            phoenix += @"       .'   " + Environment.NewLine;
            return phoenix;
        }

    }
}

