using BookLibrary.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels
{
    public class BookEditViewModel
    {
        public int BookId { get; set; }
        public BookShortDto Book { get; set; }
    }
}