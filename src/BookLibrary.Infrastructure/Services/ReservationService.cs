using BookLibrary.Domain.Models;
using BookLibrary.Infrastructure.Dal;
using BookLibrary.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Services
{
    public class ReservationService : IReservationService
    {
        private readonly LibraryContext _context;

        public ReservationService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(int userId, int bookId)
        {
            try
            {
                var reservation = new Reservation(userId, bookId);

                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Reservation>> GetAllByBookId(int bookId) => await _context.Reservations.Where(x => x.BookId == bookId).Include(y => y.User).ToListAsync();
    }
}