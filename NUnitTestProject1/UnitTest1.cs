using NUnit.Framework;
using AireMain.Classes;

namespace AireMain.Classes.Tests.GetLyricsLength
{
    [TestFixture]
    public class GetLyricsLengthTests
    {
        private static AireMain.Classes.GetLyricsLength getLyricsLengthTest;

        [SetUp]
        public void Setup()
        {
            getLyricsLengthTest = new Classes.GetLyricsLength();
        }

        [Test]
        public void TestCounterLyrics()
        {
            //arrange
           var artistName = "Coldplay";
            var titleName = "Paradise";
            double expected = 500;

            // act
            var lengthOfLyrics = getLyricsLengthTest(artistName, titleName);
             
            //assert
            Assert.AreEqual(expected, lengthOfLyrics);
        }
    }
}