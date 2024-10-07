using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HOST_Telery.Controllers.v1.BookingControllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Tags("booking")]
    public class BookingDeleteController : BookingController
    {
        public BookingDeleteController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }


    }
}