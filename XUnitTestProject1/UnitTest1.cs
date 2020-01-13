using NUnit.Framework;
using System; 
namespace AireMain.Classes.Tests.Defence
{
    [TestFixture]
    public class LyricsTest
    {
        [Test]
        public void CounterLyrics()
        {
            // arrange
            var artistName = "Coldplay";
            var titleName = "Paradise";
            double expected = 500;

            // act
            var lengthOfLyrics = getLyricsLength(artistName, titleName);

            //assert
            Assert.AreEqual(expected, lengthOfLyrics);
        }
    }