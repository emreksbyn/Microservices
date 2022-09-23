using Reservation.API.Models.Models;

namespace Reservation.API.Infrastructure.AbstractServices
{
    public interface IReservationService
    {
        ReservationDto GetResByBkgNumber(int bkgNumber);
    }
}