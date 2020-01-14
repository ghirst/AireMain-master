using System;

namespace AireMain.Classes
{
    public class CmdImgs
    {
        internal static string PhoenixIcon()
        {
            ColourMagic.OhLookColorMagic("phoenix");

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