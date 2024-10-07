using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Models;

namespace HOST_Telery.Repository
{
    public interface IRoomTypeRepository
    {
        Task<IEnumerable<RoomType>> GetAll();
        Task<RoomType> GetRoomTypeById(int id);
        Task Add(RoomType roomType);
        Task Update(RoomType roomType);
        Task Delete(int id);
    }
}