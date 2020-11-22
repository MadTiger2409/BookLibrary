using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Dto
{
    public class ReservationDto
    {
        public string UserLogin { get; set; }
        public DateTime ReservedAt { get; set; }
    }
}