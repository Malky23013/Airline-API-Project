using Solid.API;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using Solid.API.Entities;
using System.Runtime.CompilerServices;
using AutoMapper;
using Solid.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;
        private readonly IMapper _mapper;
        public FlightsController(IFlightService userService,IMapper mapper)
        {
            _flightService = userService;
            _mapper = mapper;   
        }

        // GET: api/<EventsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _flightService.GetFlightsAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var flight =await _flightService.GetByIdAsync(id);
            if (flight is null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<FlightDto>(flight));
        }
        //POST api/<EventsController>
        [HttpPost]
        public async Task Post([FromBody] Flight newE)
        {
           await _flightService.AddFlightAsync(new Flight { Company = newE.Company, Destination = newE.Destination, Source = newE.Source });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Flight>> Put(int id, [FromBody] Flight updateEvent)
        {
          return Ok(await _flightService.UpdateFlightAsync(id, updateEvent));  
        }

        //// DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public async Task  Delete(int id)
        {
           await _flightService.DeleteFlightAsync(id);
        }
    }
    
}

