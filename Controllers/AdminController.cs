using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private AdminService _admin;
        public AdminController(AdminService admin)
        {
            _admin = admin;
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            return Ok(_admin.AddAdmin(admin));
        }
    }
}
