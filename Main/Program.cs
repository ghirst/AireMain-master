using AireMain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AireMain
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        public static async Task MainAsync()
        { 
            try
            {
                Console.WriteLine("Let's go grab the worlds songs!");
                var SingersCollection = new List<string>();
                GetBandName(SingersCollection);

                var tasks = (from string artistName in SingersCollection
                             let task = GetMyStuff.DictionarySongsByArtistAsync(artistName)
                             select task).ToList();

                await Task.WhenAll(tasks);
                Console.WriteLine("Done");
            }
            catch (System.IO.IOException e)
            {
                ColourMagic.OhLookColorMagic("ohno");
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e);
            }
            finally
            { 
                Console.WriteLine(CmdImgs.PhoenixIcon());
                Console.ReadLine();
            }
        }
  
        private static void GetBandName(List<string> singersCollection)
        {
            Console.WriteLine("Enter a band name or press enter to start the counting:");
            string artistName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(artistName))
            {
                singersCollection.Add(artistName);
                GetBandName(singersCollection);
            }
        }
    }
}