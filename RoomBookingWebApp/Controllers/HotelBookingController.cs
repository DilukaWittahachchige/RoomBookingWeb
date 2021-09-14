using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoomBookingWebApp.Controllers
{
    [Route("api/[hotel-booking]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {




        // GET: api/<HotelBookingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HotelBookingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HotelBookingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HotelBookingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HotelBookingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
