using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleDatabase.Models
{
    //The DTO are in this case the same as the model, this is to show how to use a DTO
    public class VehicleDTO
    {
        // PK
        public long Id { get; set; }
        //FK
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int FuelId { get; set; }
        public int EquipmentId { get; set; }
        // Data
        public string ModelName { get; set; }
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
    }
}
