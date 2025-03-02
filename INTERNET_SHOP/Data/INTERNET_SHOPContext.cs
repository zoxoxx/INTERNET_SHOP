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

        public DbSet<INTERNET_SHOP.Models.User> User { get; set; } = default!;
        public DbSet<TypeProduct> TypeProducts { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<Cinema> Cinema { get; set; } = default!;
        public DbSet<City> City { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<Ticket> Ticket { get; set; } = default!;

    }
}
