using Solid.API.Entities;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{ 

    public class Mapping
    {
        public FlightDto MapToFlightDto(Flight flight)
        {
            return new FlightDto { Company=flight.Company,Destination=flight.Destination,Source=flight.Source};
        }
        public TicketDto MapToTicketDto(Ticket ticket)
        {
            return new TicketDto { Company=ticket.Company,Date=ticket.Date,Price=ticket.Price,Id=ticket.Id};
        }
        public PassengerDto MapToPassengerDto(Passenger passenger)
        {
            return new PassengerDto { Id=passenger.Id,Age=passenger.Age,FirstName=passenger.FirstName,LastName=passenger.LastName};
        }
    }
}
