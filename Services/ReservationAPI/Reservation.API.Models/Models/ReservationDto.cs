namespace Reservation.API.Models.Models
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public DateTime? BkgDate { get; set; }
        public double Amount { get; set; }
    }
}