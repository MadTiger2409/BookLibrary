using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Domain.Models
{
    public class Reservation
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime ReservedAt { get; set; }

        public User User { get; set; }
        public Book Book { get; set; }

        public Reservation(int userId, int bookId)
        {
            UserId = userId;
            BookId = bookId;
            ReservedAt = DateTime.UtcNow;
        }
    }
}