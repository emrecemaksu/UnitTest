using System;
using System.Collections.Generic;
using System.Linq;

namespace TestNinja.Mocking
{
    public static class BookingHelper
    {
        
        public static string OverlappingBookingsExist(Booking booking, IBookHelp bookHelp)
        {
            if (booking.Status == "Cancelled")
                return string.Empty;

            var bookings = bookHelp.Query<Booking>().Where(b => b.Id != booking.Id && b.Status != "Cancelled");

            var overlappingBooking =
                bookings.FirstOrDefault(
                    b =>
                        booking.ArrivalDate < b.DepartureDate
                        && b.ArrivalDate < booking.DepartureDate);

            return overlappingBooking == null ? string.Empty : overlappingBooking.Reference;
        }
    }
    public class Booking
    {
        public string Status { get; set; }
        public int Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Reference { get; set; }
    }
}