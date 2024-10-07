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
    public class GuestServices : IGuestRepository
    {

        private readonly MyDbContext _context;

        public GuestServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Guest guest)
        {
            await _context.Guests.AddAsync(guest);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ToDelete = await GetGuestById(id);
            if (ToDelete != null)
            {
                _context.Guests.Remove(ToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Guest>> GetAll()
        {
            return await _context.Guests.ToListAsync();
        }

        public async Task<Guest> GetGuestById(int id)
        {
            return await _context.Set<Guest>().FindAsync(id);
        }

        public async Task Update(Guest guest)
        {
            _context.Entry(guest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}