using Solid.API;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using System.Net.Sockets;
using Solid.API.Entities;
using AutoMapper;
using Solid.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {

        // GET: api/<EventsController>
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;
        public TicketsController(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
           _mapper = mapper;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ticketService.GetTickets());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ticket = _ticketService.GetById(id);
            if (ticket is null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<TicketDto>(ticket));
        }
        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Ticket newt)
        {
            _ticketService.Add(new Ticket { Id = newt.Id, Company = newt.Company, Date = newt.Date, Price = newt.Price });
        }

        //// PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult<Ticket> Put(int id, [FromBody] Ticket updateEvent)
        {
           return Ok(_ticketService.UpdateTicket(id, updateEvent)) ;
        }

        //// DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ticketService.DeleteTicket(id);
        }
    }
}
