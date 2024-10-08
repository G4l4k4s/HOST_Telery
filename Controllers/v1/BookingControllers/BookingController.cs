using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Data;
using HOST_Telery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HOST_Telery.Controllers.v1.BookingControllers
{

    [ApiController]
    [Route("api/v1/category")]
    [Tags("booking")]

    public class BookingController : ControllerBase
    {
        protected readonly IBookingRepository servicios;

        public BookingController(IBookingRepository bookingRepository)
        {
            servicios = bookingRepository;
        }

    }
}