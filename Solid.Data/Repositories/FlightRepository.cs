using Microsoft.EntityFrameworkCore;
using Solid.API.Entities;
using Solid.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly DataContext _context;
        public FlightRepository(DataContext context)
        {
            _context = context;
        }

        //public async Task<Flight> AddFlightAsync(Flight flight)
        //{
        //    _context.FlightsList.Add(flight);
        //    //יש לי בעיה בשורה הזאת כאן
        //  // await _context.SaveChangesAsync();
        //    return flight;
        //}
        public async Task<Flight> AddFlightAsync(Flight flight)
        {
            try
            {
                _context.FlightsList.Add(flight);
                await _context.SaveChangesAsync();
                return flight;
            }
            catch (Exception ex)
            {
                // כאן יש להוסיף לוגיקה או להדפיס שגיאה
                // ניתן גם לעבור על השגיאה ולבדוק את הפרטים שבה
                Console.WriteLine($"Error adding flight: {ex.Message}");
                throw;
            }
        }

        public async Task DeleteFlightAsync(int id)
        {
            var flightToDelete = _context.FlightsList.FirstOrDefault(u => u.Id == id);

            if (flightToDelete != null)
            {
                _context.FlightsList.Remove(flightToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Flight?> GetByIdAsync(int id)
        {
            return await Task.Run(() => _context.FlightsList.FirstOrDefault(u => u.Id == id));
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            return await _context.FlightsList.ToListAsync();
        }

        public async Task<Flight?> UpdateFlightAsync(int id, Flight flight)
        {
            var updateFlight = _context.FlightsList.FirstOrDefault(u => u.Id == id);
            if (updateFlight != null)
            {
                updateFlight.Company = flight.Company;
                updateFlight.Destination = flight.Destination;
                updateFlight.Source = flight.Source;
                await _context.SaveChangesAsync();
                return updateFlight;
            }
            return null;
        }
    }
}
