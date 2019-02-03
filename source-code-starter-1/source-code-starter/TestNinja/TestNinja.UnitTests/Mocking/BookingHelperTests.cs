using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestClass]
    public class BookingHelperTests
    {
        [TestMethod]
        public void BookingStartAndFinishesBeforeAnExistingBooking_ReturnEmptyString()
        {
            var _bookhelp = new Mock<IBookHelp>();
            var booking = new Booking {
                Id = 1,
                ArrivalDate = new DateTime(2018, 1, 15, 14, 0, 0),
                DepartureDate = new DateTime(2018, 1, 20, 10, 0, 0),
                Reference = "a",
                Status = "Ready"
            };
            var bookhelp = BookingHelper.OverlappingBookingsExist(booking, _bookhelp.Object);
            var result = bookhelp.ToString();
            Assert.AreEqual(result, "");

        }
    }
}
