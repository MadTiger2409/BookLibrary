using BookLibrary.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Commands.Book
{
    public class UpdateBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }

        public UpdateBook()
        {
        }

        public UpdateBook(BookDto dto)
        {
            Id = dto.Id;
            Title = dto.Title;
            Author = dto.Author;
            Description = dto.Description;
            ReleaseDate = dto.ReleaseDate;
        }
    }
}