using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Commands.Book
{
    public class CreateBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}