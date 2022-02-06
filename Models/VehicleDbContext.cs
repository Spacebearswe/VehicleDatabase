using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VehicleDatabase.Models
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; } // Vehicle has CRUD functions
        public DbSet<Color> Colors { get; set; } // Predefiend colors - No CRUD functions

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed colors
            modelBuilder.Entity<Color>().HasData(new Color { Id = 1, ColorName = "Red" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 2, ColorName = "Green" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 3, ColorName = "Blue" });

            // Seed Vehicle
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 1, ColorId = 1, ModelName = "Volvo XC90", PlateNumber = "BIL001", VIN = " YV1AA8843M1345789" });

        }
    }
}