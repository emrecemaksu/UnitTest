using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void GetUnprocessedVideosAsCsv_AllVideo_Processed_Return_Empty_String()
        {
            var _repository = new Mock<IVideoRepository>();
            var _fileReader = new Mock<IFileReader>();
            var _videoService2 = new VideoService(_fileReader.Object, _repository.Object);
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>());
            var result = _videoService2.GetUnprocessedVideosAsCsv();
            Assert.AreEqual(result, "");
        }
        [TestMethod]
        public void GetUnprocessedVideosAsCsv_Video_Processed_Return_ID_String()
        {
            var _repository = new Mock<IVideoRepository>();
            var _fileReader = new Mock<IFileReader>();
            var _videoService2 = new VideoService(_fileReader.Object, _repository.Object);
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video> {
                new Video{Id = 1},
                new Video{Id = 2},
                new Video{Id = 3}
            });
            var result = _videoService2.GetUnprocessedVideosAsCsv();
            Assert.AreEqual(result, "1,2,3");
        }
    }
}
