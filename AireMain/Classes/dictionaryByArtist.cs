using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AireMain.Classes
{
    public class getMyStuff
    {
        public static int DictionarySongsByArtist(string artistName, ref int i, ref int totalLyricLength)
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
            colourMagic.ohLookColorMagic("AL");

          
            loopSongTitles(artistName, myDict, titleList, ref i, ref totalLyricLength);

            Console.WriteLine("Total" + totalLyricLength);
            Console.WriteLine("Total" + i);

            //TODO Minimum
            //TODO Maximum
            //Maybe a DB would just be easier usually! That or save into a session etc...

            return totalLyricLength / i;
        }

        private static void loopSongTitles(string artistName, Dictionary<int, string> myDict, IEnumerable<XElement> titleList, ref int i, ref int totalLyricLength)
        {
            try
            {
                foreach (var element in titleList)
                {
                    if (!myDict.ContainsValue(element.Value.ToLower())) // TODO something like a task, maybe not dictionary!
                    {
                        var l = getLength(artistName, totalLyricLength, element);
                        if (l > 0)
                        {
                            totalLyricLength += l;
                            myDict.Add(i++, element.Value.ToLower());
                            Console.WriteLine(i + " " + element.Value + " " +  totalLyricLength); 
                            //TODO return the value of totalLyricLength and i
                            //wondering about i, after task, async amends
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

        private static int getLength(string artistName, int totalLyricLength, XElement element)
        { 
            return getLyricsLength.GetLyricsLength(artistName, element.Value);
        }
    }
}
