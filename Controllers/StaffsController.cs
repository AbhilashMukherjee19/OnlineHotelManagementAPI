using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly StaffService S_staff;

        public StaffsController(StaffService staff)
        {
            S_staff = staff;
        }

        
        [HttpPost("InsertStaff"), Authorize(Roles = "Owner")]
        public IActionResult InsertStaff(Staff staff)
        {
            return Ok(S_staff.InsertStaff(staff));
        }

        [HttpPut("UpdateStaff"), Authorize(Roles = "Owner")]
        public IActionResult UpdateStaff(Staff customer)
        {
            return Ok(S_staff.UpdateStaff(customer));
        }

        [HttpDelete("DeleteStaff"), Authorize(Roles = "Owner")]
        public IActionResult DeleteStaff(int Id)
        {
            return Ok(S_staff.DeleteStaff(Id));
        }

        [HttpGet("GetStaffById"), Authorize(Roles = "Owner")]

        public IActionResult GetStaffById(int Id)
        {
            return Ok(S_staff.GetStaffById(Id));
        }

        [HttpGet("GetAllStaff"), Authorize(Roles = "Owner")]
        public IActionResult GetAllStaff()
        {
            return Ok(S_staff.GetAllStaff());
        }
    }
}
