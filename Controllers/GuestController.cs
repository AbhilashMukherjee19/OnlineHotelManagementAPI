using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private GuestService _guest;
        public GuestController(GuestService guest)
        {
            _guest = guest;
        }


        [HttpPost("InsertGuest"), Authorize(Roles = "Manager, Receptionist, Owner")]
        public IActionResult AddGuest(Guest guest)
        {
            return Ok(_guest.AddGuest(guest));
        }

        [HttpPut("UpdateGuest"), Authorize(Roles = "Manager, Receptionist, Owner")]
        public IActionResult UpdateGuest(Guest guest)
        {
            return Ok(_guest.UpdateGuest(guest));
        }

        [HttpDelete("DeleteGuest"), Authorize(Roles = "Manager, Receptionist, Owner")]
        public IActionResult RemoveGuest(int id)
        {
            return Ok(_guest.RemoveGuest(id));
        }

        [HttpGet("GetGuestById"), Authorize(Roles = "Manager, Receptionist, Owner")]
        public IActionResult GetGuestById(int id)
        {
            return Ok(_guest.GetById(id));
        }

        [HttpGet("GetAllGuests"), Authorize(Roles = "Manager, Receptionist, Owner")]
        public IActionResult GetAllGuests()
        {
            return Ok(_guest.GetAll());
        }
    }
}
