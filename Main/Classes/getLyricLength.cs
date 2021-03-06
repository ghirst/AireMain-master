﻿using System.Net;

namespace AireMain.Classes
{
    public class GetLyricsLength
    {
        public static int GetLyricsLengthMethod(string artistName, string titleName)
        {
            try
            {
                //Console.WriteLine("Phew, it worked:" + titleName + ":" + artistName);
                //TODO may need to remove erronours characters from feed?
                //TODO error handling if not found

                string jsonLyrics = new WebClient().DownloadString("https://api.lyrics.ovh/v1/" + artistName + "/" + titleName);
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