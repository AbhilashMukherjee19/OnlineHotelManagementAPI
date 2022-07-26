using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationService S_reservation;

        public ReservationController(ReservationService reservation)
        {
            S_reservation = reservation;
        }

        [HttpPost("InsertReservation"), Authorize(Roles = "Receptionist")]
        public IActionResult InsertReservation(Reservation reservation)
        {
            return Ok(S_reservation.InsertReservation(reservation));
        }

        [HttpDelete("DeleteReservation"), Authorize(Roles = "Receptionist")]
        public IActionResult DeleteReservation(int Id)
        {
            return Ok(S_reservation.DeleteReservation(Id));
        }

        [HttpPut("UpdateReservation"), Authorize(Roles = "Receptionist")]
        public IActionResult UpdateReservation(Reservation reservation)
        {
            return Ok(S_reservation.UpdateReservation(reservation));
        }

        [HttpGet("GetReservationById"), Authorize(Roles = "Manager")]

        public IActionResult GetReservationById(int Id)
        {
            return Ok(S_reservation.GetReservationById(Id));
        }
    }
}
