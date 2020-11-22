using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Dto
{
    public class BookUserIdsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public IEnumerable<int> UserIds { get; set; }
    }
}