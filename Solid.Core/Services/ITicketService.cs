using Solid.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ITicketService
    {
        List<Ticket> GetTickets();

        Ticket GetById(int id);
        Ticket Add(Ticket flight);
        public void DeleteTicket(int id);
        public Ticket UpdateTicket(int id, Ticket ticket);
    }
}
