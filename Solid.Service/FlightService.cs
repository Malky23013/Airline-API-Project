using Solid.API.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class FlightService:IFlightService
    {
        private readonly IFlightRepository _flightRepository;

        public FlightService(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            return await _flightRepository.GetFlightsAsync();
        }

        public async Task<Flight?> GetByIdAsync(int id)
        {
            return await _flightRepository.GetByIdAsync(id);
        }
        public async Task<Flight> AddFlightAsync(Flight flight)
        {
            return await _flightRepository.AddFlightAsync(flight);
        }

        public async Task DeleteFlightAsync(int id)
        {
            await _flightRepository.DeleteFlightAsync(id);
        }

        public async Task<Flight?> UpdateFlightAsync(int id, Flight flight)
        {
            return await _flightRepository.UpdateFlightAsync(id, flight);
        }
    }
}
