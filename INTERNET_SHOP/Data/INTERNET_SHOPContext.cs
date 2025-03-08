using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using INTERNET_SHOP.Models;

namespace INTERNET_SHOP.Data
{
    public class INTERNET_SHOPContext : DbContext
    {
        public INTERNET_SHOPContext (DbContextOptions<INTERNET_SHOPContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hall>()
                .HasOne(h => h.Cinema)
                .WithMany(c => c.Halls)
                .HasForeignKey(h => h.CinemaId)
                .OnDelete(DeleteBehavior.Restrict); // Указываем "Restrict", чтобы запретить каскадное удаление

            modelBuilder.Entity<Cinema>()
                .HasOne(c => c.City) // Один Город связан с многими Cinema
                .WithMany()
                .HasForeignKey(c => c.CityId)
                .OnDelete(DeleteBehavior.Restrict); // Установите ограничитель удаления

            modelBuilder.Entity<Ticket>()
                .HasOne(c => c.Schedule) // Один Город связан с многими Cinema
                .WithMany()
                .HasForeignKey(c => c.ScheduleId)
                .OnDelete(DeleteBehavior.Restrict); // Установите ограничитель удаления

        }

        public DbSet<INTERNET_SHOP.Models.User> User { get; set; } = default!;
        public DbSet<TypeProduct> TypeProducts { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<Cinema> Cinema { get; set; } = default!;
        public DbSet<City> City { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<Ticket> Ticket { get; set; } = default!;
        public DbSet<Position> Position { get; set; } = default!;
        public DbSet<Hall> Hall { get; set; } = default!;
        public DbSet<Schedule> Schedule { get; set; } = default!;

    }
}
