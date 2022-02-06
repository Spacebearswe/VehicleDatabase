using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleDatabase.Models
{
    //The DTO are in this case the same as the model, this is to show how to use a DTO
    public class VehicleDTO
    {
        public long Id { get; set; }
        public int ColorId { get; set; }
        public string ModelName { get; set; }
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
    }
}
