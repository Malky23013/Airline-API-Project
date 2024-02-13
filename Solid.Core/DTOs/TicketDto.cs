using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class TicketDto
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }
        public DateTime Date { get; set; }
    }
}
