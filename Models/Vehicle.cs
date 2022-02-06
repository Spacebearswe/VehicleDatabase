using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleDatabase.Models
{
    public class Vehicle
    {
        public long Id { get; set; }
        public string ModelName { get; set; }
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
    }
}
