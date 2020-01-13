using System.Net;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Drawing;
using AireMain.Classes;
using System.Threading.Tasks;

namespace AireMain
{
    class Program
    {
        static void Main(string[] args)
        {
             
            MainAsync().Wait();

        }

        public static async Task MainAsync()
        {

            //     Console.WriteLine("Let's go grab the worlds songs!"); 
            try
            {
                string artistName1, artistName2;

                getartistNames(out artistName1, out artistName2);
                

                //myDict.Add(artistName, 1); 
                //myDict.Add(artistName, 2);

                //TODO Loop artists
                //Dictionary
                Dictionary<string, int> myDict = new Dictionary<string, int>();

                Task lyricLength1 = GetAPI(artistName1);
                Task lyricLength2 = GetAPI(artistName2);

                await Task.WhenAll(lyricLength1, lyricLength2);


                var w1 = " has an average of ";
                var w2 = " words per single.";

                Console.WriteLine(artistName1 + w1 + lyricLength1 + w2);
                Console.WriteLine(artistName2 + w1 + lyricLength2 + w2);
            }
            //TODO TEST!   
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Done");
                Console.ReadLine();
            }
        }

        private static void getartistNames(out string artistName1, out string artistName2)
        {
            Console.WriteLine("Enter your first band name: (okay it's a test it's going to run Coldplay)");
            artistName1 = Console.ReadLine();
            artistName1 = "Coldplay";

            Console.WriteLine("Enter your second band name: (okay it's a test it's going to run Nina)");
            artistName2 = Console.ReadLine();
            artistName2 = "Nina";
        }

        private static async Task GetAPI(string artistName)
        {
            await Task.Run(() =>
            {
                var artistLyricLength = getMyStuff.DictionarySongsByArtist(artistName);

                return artistLyricLength;
            });
        }
    }
}
