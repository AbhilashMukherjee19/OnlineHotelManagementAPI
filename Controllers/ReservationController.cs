using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationService S_reservation;
        private HotelContext _context;

        public ReservationController(ReservationService reservation, HotelContext context)
        {
            S_reservation = reservation;
            _context = context;
        }

        #region InsertReservation
        [HttpPost("InsertReservation")/*, Authorize(Roles = "Receptionist, Manager, Owner")*/]
        public IActionResult InsertReservation(Reservation reservation)
        {
            return Ok(S_reservation.InsertReservation(reservation));
        }
        #endregion

        #region UpdateReservation
        [HttpPut("UpdateReservation")/*, Authorize(Roles = "Receptionist, Manager, Owner")*/]
        public IActionResult UpdateReservation(Reservation reservation)
        {
            return Ok(S_reservation.UpdateReservation(reservation));
        }
        #endregion

        #region DeleteReservation
        [HttpDelete("DeleteReservation")/*, Authorize(Roles = "Receptionist, Manager, Owner")*/]
        public IActionResult DeleteReservation(int Id)
        {
            return Ok(S_reservation.DeleteReservation(Id));
        }
        #endregion

        #region GetReservationById
        [HttpGet("GetReservationById")/*, Authorize(Roles = "Receptionist, Manager, Owner")*/]
        public IActionResult GetReservationById(int Id)
        {
            if (S_reservation.GetReservationById(Id) == "200")
            {
                return Ok(_context.Reservations.Find(Id));
            }
            else
            {
                return Ok(new { message = "Not Found" });
            }
        }
        #endregion

        #region GetAllReservations
        [HttpGet("GetAllReservations")/*, Authorize(Roles = "Manager, Receptionist, Owner")*/]
        public IActionResult GetAllReservation()
        {
            return Ok(S_reservation.GetAllReservation());
        }
        #endregion
    }
}
