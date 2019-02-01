using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestClass]
    public class VideoServiceTests
    {
        [TestMethod]
        public void ReadVideoTitle_EmptyFile_ReturnErorr_Message()
        {
            var _fileReader = new Mock<IFileReader>();
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            var _videoService = new VideoService(_fileReader.Object);
            var result = _videoService.ReadVideoTitle();
            Assert.AreEqual(result, "Error parsing the video.");
        }
    }
}
