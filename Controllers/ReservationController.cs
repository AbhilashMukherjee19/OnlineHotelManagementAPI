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

        [HttpGet, Authorize(Roles = "Manager, Receptionist, Owner")]
        public IActionResult GetAllReservation()
        {
            return Ok(S_reservation.GetAllReservation());
        }

        [HttpPost("InsertReservation"), Authorize(Roles = "Receptionist, Manager, Owner")]
        public IActionResult InsertReservation(Reservation reservation)
        {
            return Ok(S_reservation.InsertReservation(reservation));
        }

        [HttpDelete("DeleteReservation"), Authorize(Roles = "Receptionist, Manager, Owner")]
        public IActionResult DeleteReservation(int Id)
        {
            return Ok(S_reservation.DeleteReservation(Id));
        }

        [HttpPut("UpdateReservation"), Authorize(Roles = "Receptionist, Manager, Owner")]
        public IActionResult UpdateReservation(Reservation reservation)
        {
            return Ok(S_reservation.UpdateReservation(reservation));
        }

        [HttpGet("GetReservationById"), Authorize(Roles = "Receptionist, Manager, Owner")]

        public IActionResult GetReservationById(int Id)
        {
            return Ok(S_reservation.GetReservationById(Id));
        }
    }
}
