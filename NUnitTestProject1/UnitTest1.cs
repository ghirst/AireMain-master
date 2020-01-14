using NUnit.Framework;
using Calc.Classes;

namespace Calc.Classes.Tests.GetLyricsLength
{
    [TestFixture]
    public class GetLyricsLengthTests
    {
        private Calc.Classes.GetLyricsLength getLyricsLengthTest;

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


            //  var lengthOfLyrics = getLyricsLengthTest(artistName, titleName);
            var lengthOfLyrics = "z";

            //assertvar lengthOfLyrics = 
            Assert.AreEqual(expected, lengthOfLyrics);
        }
    }
}