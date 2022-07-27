using Microsoft.AspNetCore.Authorization;
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


        [HttpPost("InsertRoom"), Authorize(Roles = "Manager, Owner")]
        public IActionResult AddRoom(Room room)
        {
            return Ok(_room.AddRoom(room));
        }

        [HttpPut("UpdateRoom"), Authorize(Roles = "Manager, Owner")]
        public IActionResult UpdateRoom(Room room)
        {
            return Ok(_room.UpdateRoom(room));
        }

        [HttpDelete("RemoveId"), Authorize(Roles = "Manager, Owner")]
        public IActionResult RemoveRoom(int id)
        {
            return Ok(_room.RemoveRoom(id));
        }

        [HttpGet("GetRoomById"), Authorize(Roles = "Receptionist, Manager, Owner")]
        public IActionResult GetRoomById(int id)
        {
            return Ok(_room.GetById(id));
        }

        [HttpGet("GetAllRooms"), Authorize(Roles = "Receptionist, Manager, Owner")]
        public IActionResult GetAllRooms()
        {
            return Ok(_room.GetAll());
        }
    }
}
