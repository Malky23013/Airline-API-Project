using Solid.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IPassengerService
    {
        List<Passenger> GetPassengers();

        Passenger GetById(int id);
        Passenger Add(Passenger flight);
        public void DeletePassenger(int id);
        public Passenger UpdatePassenger(int id, Passenger passenger);
    }
}
