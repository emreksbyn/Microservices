using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure.AbstractServices;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            this._reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _reservationService.GetResByBkgNumber(id);
            return Ok(result);
        }
    }
}