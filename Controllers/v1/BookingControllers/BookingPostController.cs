using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Models;
using HOST_Telery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HOST_Telery.Controllers.v1.BookingControllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Tags("booking")]
    public class BookingPostController : BookingController
    {
        public BookingPostController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Add(Booking booking)
        {
            await servicios.Add(booking);
            return Ok("Category created successfully");
        }

    }
}