using AutoMapper;
using Solid.API.Entities;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FlightDto, Flight>().ReverseMap();
            CreateMap<TicketDto, Ticket>().ReverseMap();
            CreateMap<PassengerDto, Passenger>().ReverseMap();
        }
    }
}
