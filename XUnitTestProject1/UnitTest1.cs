using AireMain.Classes; 
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnArtistName()
        {
            // TODO : Write test code 
            var artistName = "Coldplay";
            var elementValue = "50";

            getLyricsLength gLL = new getLyricsLength.GetLyricsLength(artistName, elementValue);
            double res = gLL.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        }
    }
}
