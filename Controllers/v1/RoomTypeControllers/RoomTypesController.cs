using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HOST_Telery.Controllers.v1.RoomTypeControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypesController : ControllerBase
    {
        protected readonly IRoomTypeRepository servicios;

        public RoomTypesController(IRoomTypeRepository roomTypeRepository)
        {
            servicios = roomTypeRepository;
        }

        // GET api/roomtypes
        [HttpGet]
        public async Task<IActionResult> GetAllRoomTupes()
        {
            var roomTypes = await servicios.GetAll();

            if (roomTypes == null || roomTypes.Count() == 0)
            {
                return NoContent();
            }
            return Ok(roomTypes);
        }
    }
}