using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}