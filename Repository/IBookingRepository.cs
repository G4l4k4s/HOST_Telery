using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Models;

namespace HOST_Telery.Repository
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAll();
        Task<Booking> GetBookingById(int id);
        Task Add(Booking booking);
        Task Update(Booking booking);
        Task Delete(int id);
    }
}