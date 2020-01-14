using NUnit.Framework;

namespace AireMain.Classes.Tests.GetLyricsLength
{
    [TestFixture]
    public class Test1
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
}