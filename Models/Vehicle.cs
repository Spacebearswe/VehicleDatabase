﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleDatabase.Models
{
    // The class that the databasetable are connected to 
    public class Vehicle
    {
        //PK
        public long Id { get; set; }
        //FK
        public int ColorId { get; set; }
        //Data
        public string ModelName { get; set; }
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
    }
}
