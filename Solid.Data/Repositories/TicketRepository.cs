using Solid.API.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class TicketRepository:ITicketRepository
    {
        private readonly DataContext _context;
        public TicketRepository(DataContext context)
        {
            _context = context;
        }
        public Ticket AddTicket(Ticket ticket)
        {
            _context.tickets.Add(ticket);
            return ticket;
        }

        public void DeleteTicket(int id)
        {
            _context.tickets.Remove(_context.tickets.ToList().Find(u => u.Id == id));
        }

        public Ticket GetById(int id)
        {
            return _context.tickets.ToList().Find(u => u.Id == id);
        }

        public List<Ticket> GetTickets()
        {
            return _context.tickets.ToList();
        }

        public Ticket UpdateTicket(int id, Ticket ticket)
        {
            var updateTicket = _context.tickets.ToList().Find(u => u.Id == id);
            if (updateTicket != null)
            {
                updateTicket.Company = ticket.Company;
                updateTicket.Price =ticket.Price;
                updateTicket.Id =ticket.Id;
                updateTicket.Date =ticket.Date;
               
                return updateTicket;
            }
            return null;
        }
    }
}
