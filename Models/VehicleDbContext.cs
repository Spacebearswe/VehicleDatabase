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

            // Seed brand
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 1, BrandName = "Volvo" });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 2, BrandName = "BMW" });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 3, BrandName = "Opel" });

            // Seed colors
            modelBuilder.Entity<Color>().HasData(new Color { Id = 1, ColorName = "Red" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 2, ColorName = "Green" });
            modelBuilder.Entity<Color>().HasData(new Color { Id = 3, ColorName = "Blue" });

            // Seed equipment
            modelBuilder.Entity<Equipment>().HasData(new Equipment { Id = 1, EquipmentName = "Sunroof" });
            modelBuilder.Entity<Equipment>().HasData(new Equipment { Id = 2, EquipmentName = "Power Tailgate" });
            modelBuilder.Entity<Equipment>().HasData(new Equipment { Id = 3, EquipmentName = "4WD" });

            // Seed equipment
            modelBuilder.Entity<Fuel>().HasData(new Fuel { Id = 1, FuelName = "95" });
            modelBuilder.Entity<Fuel>().HasData(new Fuel { Id = 2, FuelName = "98" });
            modelBuilder.Entity<Fuel>().HasData(new Fuel { Id = 3, FuelName = "Diesel" });

            // Seed Vehicle
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle { Id = 1, BrandId = 1, ColorId = 1, EquipmentId = 1, FuelId = 3, ModelName = "XC90", PlateNumber = "BIL001", VIN = " YV1AA8843M1345789" });

        }
    }
}