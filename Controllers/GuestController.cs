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
        [HttpGet,Authorize(Roles = "Manager")]
        public IActionResult GetAllGuests()
        {
            return Ok(_guest.GetAll());
        }

        [HttpGet("ById"),Authorize(Roles = "Manager")]
        public IActionResult GetGuestById(int id)
        {
            return Ok(_guest.GetById(id));
        }

        [HttpPost, Authorize(Roles = "Manager")]
        public IActionResult AddGuest(Guest guest)
        {
            return Ok(_guest.AddGuest(guest));
        }

        [HttpPut, Authorize(Roles = "Manager")]
        public IActionResult UpdateGuest(Guest guest)
        {
            return Ok(_guest.UpdateGuest(guest));
        }

        [HttpDelete("ById"), Authorize(Roles = "Manager")]
        public IActionResult RemoveGuest(int id)
        {
            return Ok(_guest.RemoveGuest(id));
        }

    }
}
