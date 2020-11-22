using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Domain.Models
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public IEnumerable<User> Users { get; set; }

        public Book(string title, string author, string description, DateTime releaseDate) : base()
        {
            Title = title;
            Author = author;
            Description = description;
            ReleaseDate = releaseDate;
        }

        public void Update(string title, string author, string description, DateTime releaseDate)
        {
            Title = title;
            Author = author;
            Description = description;
            ReleaseDate = releaseDate;
        }
    }
}