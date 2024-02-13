using Solid.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ITicketRepository
    {
        List<Ticket> GetTickets();

        Ticket GetById(int id);

        Ticket AddTicket(Ticket ticket);

        Ticket UpdateTicket(int id, Ticket ticket);

        void DeleteTicket(int id);
    }
}
