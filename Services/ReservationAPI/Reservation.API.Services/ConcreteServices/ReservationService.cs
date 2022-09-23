using Reservation.API.Infrastructure.AbstractServices;
using Reservation.API.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services.ConcreteServices
{
    public class ReservationService : IReservationService
    {
        public ReservationDto GetResByBkgNumber(int bkgNumber)
        {
            return new ReservationDto()
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(1000),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
                BkgNumber = bkgNumber
            };
        }
    }
}