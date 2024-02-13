using Solid.API.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class PassengerRepository:IPassengerRepository
    {
        private readonly DataContext _context;
        public PassengerRepository(DataContext context)
        {
            _context = context;
        }
        public Passenger AddPassenger(Passenger passenger)
        {
            _context.passengers.Add(passenger);
            return passenger;
        }

        public void DeletePassenger(int id)
        {
            _context.passengers.Remove(_context.passengers.ToList().Find(u => u.Id == id));
        }

        public Passenger GetById(int id)
        {
            return _context.passengers.ToList().Find(u => u.Id == id);
        }

        public List<Passenger> GetPassengers()
        {
            return _context.passengers.ToList();
        }

        public Passenger UpdatePassenger(int id, Passenger passenger)
        {
            var updatePassenger = _context.passengers.ToList().Find(u => u.Id == id);
            if (updatePassenger != null)
            {
                updatePassenger.Id = passenger.Id;
                updatePassenger.FirstName = passenger.FirstName;
                updatePassenger.LastName = passenger.LastName;
                updatePassenger.Age = passenger.Age;
                return updatePassenger;
            }
            return null;
        }
    }
}
