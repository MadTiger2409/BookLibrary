using BookLibrary.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Services.Interfaces
{
    public interface IReservationService
    {
        Task<bool> CreateAsync(int userId, int bookId);

        Task<IEnumerable<Reservation>> GetAllByBookId(int bookId);
    }
}