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
    public class RoomTypeServices : IRoomTypeRepository
    {

        private readonly MyDbContext _context;

        public RoomTypeServices(MyDbContext context)
        {
            _context = context;
        }


        public async Task Add(RoomType roomType)
        {
            await _context.RoomTypes.AddAsync(roomType);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ToDelete = await GetRoomTypeById(id);
            if (ToDelete != null)
            {
                _context.RoomTypes.Remove(ToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<RoomType>> GetAll()
        {
            return await _context.RoomTypes.ToListAsync();
        }

        public async Task<RoomType> GetRoomTypeById(int id)
        {
            return await _context.Set<RoomType>().FindAsync(id);
        }

        public async Task Update(RoomType roomType)
        {
            _context.Entry(roomType).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}