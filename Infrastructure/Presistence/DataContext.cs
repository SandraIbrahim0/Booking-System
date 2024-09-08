using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Presistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<Booking> Booking { get; set; }

    }
}
