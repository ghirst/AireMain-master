using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace AireMain.Classes
{
    public class GetLyricsLength
    {
        public static int getLyricsLength(string artistName, string titleName)
        {
            //  Console.WriteLine("Phew, it worked:" + titleName + ":" + artistName); 
            //TODO may need to remove erronours characters from feed?
            //TODO error handling if not found

            string jsonLyrics;
            try
            {
                jsonLyrics = new WebClient().DownloadString("https://api.lyrics.ovh/v1/" + artistName + "/" + titleName);
                //Console.WriteLine(jsonLyrics.Length.ToString());

                var l = 0;
                var wrd = 1;

                while (l <= jsonLyrics.Length - 1)
                {
                    /* check whether the current character is white space or new line or tab character*/
                    if (jsonLyrics[l] == ' ' || jsonLyrics[l] == '\n' || jsonLyrics[l] == '\t')
                    {
                        wrd++;
                    }

                    l++;
                }
                return jsonLyrics.Length;
            }
            catch
            {
                return 0;
            } 
        }
    }
}
