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
    public class PassengerService:IPassengerService
    {
        private readonly IPassengerRepository _passengerRepository;

        public PassengerService(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        public List<Passenger> GetPassengers()
        {
            return _passengerRepository.GetPassengers();
        }

        public Passenger GetById(int id)
        {
            return _passengerRepository.GetById(id);
        }
        public Passenger Add(Passenger passenger)
        {
            return _passengerRepository.AddPassenger(passenger);
        }

        public void DeletePassenger(int id)
        {
            _passengerRepository.DeletePassenger(id);
        }

        public Passenger UpdatePassenger(int id, Passenger passenger)
        {
           return _passengerRepository.UpdatePassenger(id, passenger);
        }
    }
}
