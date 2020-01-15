using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AireMain.Classes
{
    public class GetMyStuff
    {
        public static int DictionarySongsByArtist(string artistName)
        {
            var url = "http://musicbrainz.org/ws/2/release-group/?query=artist:%22" + artistName + "%22%20AND%20primarytype:%22single%22";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Hello World Super Script";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var doc = XDocument.Load(response.GetResponseStream());

            XNamespace ns = "http://musicbrainz.org/ns/mmd-2.0#";
            var titleList = doc.Descendants(ns + "title");
            //releaseTitles = x.Element(ns + "release-list").Descendants(ns + "title").Select(y => (string)y).ToArray()
            //Get song list from the albumns
            var i = 0;
            ColourMagic.OhLookColorMagic("al");

            var totalLyricLength = 0;
            var vMax = 0;
            var vMin = 0;

            LoopSongTitles(artistName, titleList, ref i, ref totalLyricLength, ref vMax, ref vMin);

            if(i == 0)
            {
                i = 1;
            }

            //TODO ensure this runs after the songs list!

            ColourMagic.OhLookColorMagic("blah");
            Console.WriteLine(artistName);
            Console.WriteLine("Sum total of " + totalLyricLength + " words");
            Console.WriteLine("Smallest number of words " + vMin);
            Console.WriteLine("Largest number of words " + vMax);
            Console.WriteLine("Total singles " + artistName + ": " + i);
            Console.WriteLine("Average word, per single, for " + artistName + ": " + (totalLyricLength / i)); 
           
            //Maybe a DB would just be easier usually! That or save into a session etc...

            return totalLyricLength / i;
        }

        private static void LoopSongTitles(string artistName, IEnumerable<XElement> titleList, ref int i, ref int totalLyricLength, ref int vMax, ref int vMin)
        {
            var spacerLength = 80;
            try
            {
                var myList = new List<KeyValuePair<int, string>>(); 
                foreach (var element in titleList)
                { 
                    if (!myList.Any(m => m.Value == element.Value))
                    {
                        myList.Add(new KeyValuePair<int, string>(i, element.Value));
                        i += 1;
                    }
                }
                //loop it
                var lengthOfLyrics = 0;

                using var sequenceEnum = myList.GetEnumerator();
                while (sequenceEnum.MoveNext())
                {
                    lengthOfLyrics = GetLyricsLength.getLyricsLengthMethod(artistName, sequenceEnum.Current.Value);
                    Console.WriteLine(sequenceEnum.Current.Key + Microsoft.VisualBasic.Constants.vbTab + " " + sequenceEnum.Current.Value.PadRight(spacerLength) + totalLyricLength);

                    if (lengthOfLyrics > 0)
                    {
                        totalLyricLength += lengthOfLyrics; 
                        if (lengthOfLyrics > vMax)
                        {
                            vMax = lengthOfLyrics;
                        }
                        if (lengthOfLyrics < vMin || vMin == 0)
                        {
                            vMin = lengthOfLyrics;
                        }
                    }
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e);
            }
            finally
            {
            }
        } 
    }
}
