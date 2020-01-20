using AireMain.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

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
            Console.WriteLine("Let's go grab the worlds songs!");
            try
            {
                var SingersCollection = new List<string>();
                getBandName(SingersCollection); 

                var tasks = (from string x in SingersCollection
                             let task = GetAPI(x)
                             select task).ToList();

                await Task.WhenAll(tasks);

            }
            catch (System.IO.IOException e)
            {
                ColourMagic.OhLookColorMagic("ohno");
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Done");

                string phoenix = CmdImgs.PhoenixIcon();
                Console.WriteLine(phoenix);
                Console.ReadLine();
            }
        }


        private static void getBandName(List<string> singersCollection)
        {
            Console.WriteLine("Enter a  band name or press enter to start the counting:");
            string artistName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(artistName))
            { 
                singersCollection.Add(artistName);
                getBandName(singersCollection);
            } 
        }

        private static async Task GetAPI(string artistName)
        {
            await Task.Run(() =>
            {
                var artistLyricLength = GetMyStuff.DictionarySongsByArtistAsync(artistName);

                return artistLyricLength;
            });
        }
    }
}