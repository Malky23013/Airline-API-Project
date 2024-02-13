using Solid.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IPassengerRepository
    {
        List<Passenger> GetPassengers();

        Passenger GetById(int id);

        Passenger AddPassenger(Passenger passenger);

        Passenger UpdatePassenger(int id, Passenger passenger);

        void DeletePassenger(int id);
    }
}
