using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Data;
using HOST_Telery.Models;
using HOST_Telery.Repository;
using Microsoft.EntityFrameworkCore;

namespace HOST_Telery.Services
{
    public class BookingServices : IBookingRepository
    {

        private readonly MyDbContext _context;

        public BookingServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ToDelete = await GetBookingById(id);
            if (ToDelete != null)
            {
                _context.Bookings.Remove(ToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Booking>> GetAll()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<Booking> GetBookingById(int id)
        {
            return await _context.Set<Booking>().FindAsync(id);
        }

        public async Task Update(Booking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}