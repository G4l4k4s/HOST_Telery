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
    public class RoomServices : IRoomRepository
    {

        private readonly MyDbContext _context;

        public RoomServices(MyDbContext context)
        {
            _context = context;
        }


        public async Task Add(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ToDelete = await GetRoomById(id);
            if (ToDelete != null)
            {
                _context.Rooms.Remove(ToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetRoomById(int id)
        {
            return await _context.Set<Room>().FindAsync(id);
        }

        public async Task Update(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}