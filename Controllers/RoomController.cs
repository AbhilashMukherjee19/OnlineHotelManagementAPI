using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private RoomService _room;
        public RoomController(RoomService room)
        {
            _room = room;
        }
        [HttpGet]
        public IActionResult GetAllRooms()
        {
            return Ok(_room.GetAll());
        }
        [HttpGet("ById")]
        public IActionResult GetRoomById(int id)
        {
            return Ok(_room.GetById(id));
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            return Ok(_room.AddRoom(room));
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            return Ok(_room.UpdateRoom(room));
        }
        [HttpDelete("ById")]
        public IActionResult RemoveRoom(int id)
        {
            return Ok(_room.RemoveRoom(id));
        }
    }
}
