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
    public class TicketService:ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public List<Ticket> GetTickets()
        {
            return _ticketRepository.GetTickets();
        }

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id);
        }
        public Ticket Add(Ticket ticket)
        {
            return _ticketRepository.AddTicket(ticket);
        }

        public void DeleteTicket(int id)
        {
            _ticketRepository.DeleteTicket(id);
        }

        public Ticket UpdateTicket(int id, Ticket ticket)
        {
            return _ticketRepository.UpdateTicket(id, ticket);
        }
    }
}
