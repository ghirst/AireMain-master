using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calc.Classes
{
    public class getMyStuff
    {
        public static int DictionarySongsByArtist(string artistName)
        {
            Dictionary<int, string> myDict = new Dictionary<int, string>();
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
            colourMagic.ohLookColorMagic("al");

            var totalLyricLength = 0;
            var vMax = 0;
            var vMin = 0;

            loopSongTitles(artistName, myDict, titleList, ref i, ref totalLyricLength, ref vMax, ref vMin);

            colourMagic.ohLookColorMagic("blah");
            Console.WriteLine(artistName);
            Console.WriteLine("Sum total of " + totalLyricLength + " words");
            Console.WriteLine("Smallest number of words " + vMin);
            Console.WriteLine("Largest number of words " + vMax);
            Console.WriteLine("Total singles " + artistName + ": " + i);
            Console.WriteLine("Average word, per single, for " + artistName + ": " + (totalLyricLength / i));

            //TODO Minimum
            //TODO Maximum
            //Maybe a DB would just be easier usually! That or save into a session etc...

            return totalLyricLength / i;
        }

        private static void loopSongTitles(string artistName, Dictionary<int, string> myDict, IEnumerable<XElement> titleList, ref int i, ref int totalLyricLength, ref int vMax, ref int vMin)
        {
            try
            {
                foreach (var element in titleList)
                {
                    if (!myDict.ContainsValue(element.Value.ToLower())) // TODO something like a task, maybe not dictionary!
                    {
                        var l = GetLyricsLength.getLyricsLengthMethod(artistName, element.Value);
                        if (l > 0)
                        {
                            totalLyricLength += l;
                            myDict.Add(i++, element.Value.ToLower());
                            var spacer = 80 - element.Value.Length; //Not quite right

                            Console.WriteLine(i + Microsoft.VisualBasic.Constants.vbTab + " " + element.Value.PadRight(spacer) + totalLyricLength);
                            //wondering about i, after task, async amends

                            if (l > vMax)
                            {
                                vMax = l;
                            }
                            if (l < vMin || vMin == 0)
                            {
                                vMin = l;
                            }
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
