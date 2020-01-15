﻿using AireMain.Classes;
using System;
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
            Console.WriteLine("Let's go grab the worlds songs!");
            try
            {  
                GetartistNames(out string artistName1, out string artistName2);  
                //I could do an array but I'm doing that elsewheres, so let's show random bits!
                Task lyricLength1 = GetAPI(artistName1);
                Task lyricLength2 = GetAPI(artistName2);

                await Task.WhenAll(lyricLength1, lyricLength2);
            }
            //TODO TEST!
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

        private static void GetartistNames(out string artistName1, out string artistName2)
        {
            Console.WriteLine("Enter your first band name: (okay it's a test it's going to run Mike Flowers)");
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
                var artistLyricLength = GetMyStuff.DictionarySongsByArtist(artistName);

                return artistLyricLength;
            });
        }
    }
}