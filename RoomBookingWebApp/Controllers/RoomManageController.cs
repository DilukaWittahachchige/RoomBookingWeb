using Common.Domain;
using IBusinessServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoomBookingWebApp.Controllers
{
    [Route("api/room-manage")]
    [ApiController]
    public class RoomManageController : ControllerBase
    {
        private readonly IRoomManagerService roomManagerService;
        public RoomManageController(IRoomManagerService _roomManagerService)
        {
            this.roomManagerService = _roomManagerService;
        }

        // GET: api/<RoomManageController>
        [HttpGet("all-available")]
        public IEnumerable<Room> LoadAvailableRooms()
        {
            return this.roomManagerService.LoadAllAvailableRooms();
        }

        // GET api/<RoomManageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoomManageController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RoomManageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoomManageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
