using EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data
{
    public class RoomBookingContext : DbContext
    {
        public RoomBookingContext(DbContextOptions<RoomBookingContext> options) : base(options)
        {
        }

        public DbSet<Code> Codes { get; set; }
        public DbSet<HotelBooking> HotelBookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Code>().ToTable("Code");
            modelBuilder.Entity<HotelBooking>().ToTable("HotelBooking");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
