using BookLibrary.Domain.Models;
using BookLibrary.Infrastructure.Commands.Book;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Services.Interfaces
{
    public interface IBookService
    {
        Task<bool> CreateAsync(CreateBook command);

        Task<bool> UpdateAsync(UpdateBook command);

        Task<IEnumerable<Book>> GetAllAsync();

        Task<Book> GetByIdAsync(int id);
    }
}