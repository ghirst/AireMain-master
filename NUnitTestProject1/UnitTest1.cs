using AireMain.Classes;
using NUnit.Framework;

namespace AireMain.Test.TestingName
{
    [TestFixture]
    public class LyricsTest
    {
        private GetLyricsLength getLyricsLength;

        [SetUp]
        public void Setup()
        {
            getLyricsLength = new GetLyricsLength();
        }

        [Test]
        public void TestCounterLyricsNotEqual()
        {
            //arrange
            var artistName = "Coldplay";
            var titleName = "Paradise";
            double expected = 500;

            // act
            //Um should use getLyricsLength and names
            var lengthOfLyrics = GetLyricsLength.getLyricsLengthMethod(artistName, titleName);

            //assertvar lengthOfLyrics =
            Assert.AreNotEqual(expected, lengthOfLyrics);
        }

        [Test]
        public void TestCounterLyricsEqual()
        {
            //arrange
            var artistName = "Coldplay";
            var titleName = "Paradise";
            double expected = 1208;

            // act
            var lengthOfLyrics = GetLyricsLength.getLyricsLengthMethod(artistName, titleName);

            //assert
            Assert.AreEqual(expected, lengthOfLyrics);
        }
    }
}