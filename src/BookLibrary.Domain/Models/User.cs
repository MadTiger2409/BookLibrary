using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Domain.Models
{
    public class User : Entity
    {
        public string Login { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Salt { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}