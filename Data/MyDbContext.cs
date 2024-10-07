using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Models;
using Microsoft.EntityFrameworkCore;

namespace HOST_Telery.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }



        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)  {  }
    }
}