using Microsoft.AspNetCore.Mvc;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class HotelBookingController : Controller
    {
        public static List<HotelBooking> bookings = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(bookings);
        }

        public IActionResult NewBooking()
        {
            HotelBooking newBooking = new HotelBooking(); 
            return View(newBooking);
            
        }

        public IActionResult ConfirmBooking(HotelBooking hotelBooking)
        {
            hotelBooking.Id += bookings.Count +1;
            bookings.Add(hotelBooking);
            return RedirectToAction(nameof(Index));
        }

    }
}
