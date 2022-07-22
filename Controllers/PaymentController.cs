using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentService S_payment;

        public PaymentController(PaymentService payment)
        {
            S_payment = payment;
        }

        [HttpPost("InsertPayment")]
        public IActionResult InsertStaff(Payment payment)
        {
            return Ok(S_payment.InsertPayment(payment));
        }

        [HttpPut("UpdatePayment")]
        public IActionResult UpdatePayment(Payment payment)
        {
            return Ok(S_payment.UpdatePayment(payment));
        }

        [HttpGet("GetAllPayment")]

        public IActionResult GetAllPayment()
        {
            return Ok(S_payment.GetAllPayment());
        }
    }
}
