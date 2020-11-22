using BookLibrary.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels
{
    public class BookDetailsViewModel
    {
        public BookShortDto Book { get; set; }
        public List<ReservationDto> Reservations { get; set; }
    }
}