using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Models;

namespace HOST_Telery.Repository
{
    public interface IGuestRepository
    {
        Task<IEnumerable<Guest>> GetAll();
        Task<Guest> GetGuestById(int id);
        Task Add(Guest guest);
        Task Update(Guest guest);
        Task Delete(int id);
    }
}