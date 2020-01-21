using AireMain.Classes;
using NUnit.Framework;

namespace AireMain.Test.TestingName
{
    [TestFixture]
    public class LyricsTest
    {
        private GetLyricsLength getLyricsLength;

        [SetUp]
        public void Setup() => getLyricsLength = new GetLyricsLength();
        public string artistName = "Coldplay";
        public string titleName = "Paradise";

        [Test]
        public void TestCounterLyricsNotEqual()
        {
            //arrange
          
            double expected = 500;

            // act
            var lengthOfLyrics = GetLyricsLength.GetLyricsLengthMethod(artistName, titleName);

            //assert
            Assert.AreNotEqual(expected, lengthOfLyrics);
        }

        [Test]
        public void TestCounterLyricsEqual()
        {
            //arrange 

            // act
            var lengthOfLyrics = GetLyricsLength.GetLyricsLengthMethod(artistName, titleName);

            //assert
            Assert.AreEqual((double)1208, lengthOfLyrics);
        }
    }
}