using AireMain.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

[TestMethod]
public void getLyricsLength()
{
    // arrange
    var artistName = "Coldplay";
    var titleName = "Paradise";
    double expected = 500;

    // act
    var lengthofLyrics = new GetLyricsLength(artistName, titleName);

    // assert
    Assert.AreEqual(expected, lengthofLyrics);
}