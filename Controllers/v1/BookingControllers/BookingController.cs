using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Data;
using Microsoft.AspNetCore.Mvc;

namespace HOST_Telery.Controllers.v1.BookingControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly MyDbContext _context;

        public BookingController(MyDbContext context)
        {
            _context = context;
        }

        // GET api/booking
    }
}