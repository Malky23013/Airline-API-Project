using Solid.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IFlightRepository
    {
        Task<IEnumerable<Flight>> GetFlightsAsync();

        Task<Flight?> GetByIdAsync(int id);

        Task<Flight> AddFlightAsync(Flight flight);

        Task<Flight?> UpdateFlightAsync(int id, Flight flight);

        Task DeleteFlightAsync(int id);
    }
}
