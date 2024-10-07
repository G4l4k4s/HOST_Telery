using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HOST_Telery.Controllers.v1.BookingControllers
{
    [ApiController]
    [Route("api/v1/booking")]
    [Tags("booking")]

    public class BookingGetController : BookingController
    {

        public BookingGetController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBookings()
        {
            var bookings = await servicios.GetAll();

            if (bookings == null || bookings.Count() == 0)
            {
                return NoContent();
            }
            return Ok(bookings);
        }


        [HttpGet("id")]
        public async Task<IActionResult> GetAllById(int id)
        {
            var bookings = await servicios.GetBookingById(id);

            if (bookings == null)
            {
                return NoContent();
            }
            return Ok(bookings);
        }
    }
}