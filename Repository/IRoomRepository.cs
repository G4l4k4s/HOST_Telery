using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Models;

namespace HOST_Telery.Repository
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room> GetRoomById(int id);
        Task Add(Room room);
        Task Update(Room room);
        Task Delete(int id);
    }
}