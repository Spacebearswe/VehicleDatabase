using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleDatabase.Models;

namespace VehicleDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly VehicleDbContext _context;

        public VehiclesController(VehicleDbContext context)
        {
            _context = context;
        }

        // GET: api/Vehicle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleDTO>>> GetVehicles()
        {
            return await _context.Vehicles
                .Select(x => VehicleDTO(x))
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleDTO>> GetVehicle(long id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);

            if (vehicle == null)
            {
                return NotFound();
            }

            return VehicleDTO(vehicle);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(long id, VehicleDTO vehicleDTO)
        {
            if (id != vehicleDTO.Id)
            {
                return BadRequest();
            }

            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            vehicle.ColorId = vehicleDTO.ColorId;
            vehicle.ModelName = vehicleDTO.ModelName;
            vehicle.PlateNumber = vehicleDTO.PlateNumber;
            vehicle.VIN = vehicleDTO.VIN;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!VehicleExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<VehicleDTO>> CreateVehicle(VehicleDTO vehicleDTO)
        {
            var vehicle = new Vehicle
            {
                ColorId = vehicleDTO.ColorId,
                ModelName = vehicleDTO.ModelName,
                PlateNumber = vehicleDTO.PlateNumber,
                VIN = vehicleDTO.VIN
            };

            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetVehicle),
                new { id = vehicle.Id },
                VehicleDTO(vehicle));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(long id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);

            if (vehicle == null)
            {
                return NotFound();
            }

            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehicleExists(long id)
        {
            return _context.Vehicles.Any(e => e.Id == id);
        }
        private static VehicleDTO VehicleDTO(Vehicle vehileItem) =>
            new VehicleDTO
            {
                Id = vehileItem.Id,
                ColorId = vehileItem.ColorId,
                ModelName = vehileItem.ModelName,
                PlateNumber = vehileItem.PlateNumber,
                VIN = vehileItem.VIN
            };
    }
}
