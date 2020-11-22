using BookLibrary.Domain.Models;
using BookLibrary.Infrastructure.Commands.Book;
using BookLibrary.Infrastructure.Dal;
using BookLibrary.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryContext _context;

        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(CreateBook command)
        {
            try
            {
                var book = new Book(command.Title, command.Author, command.Description, command.ReleaseDate);

                _context.Books.Add(book);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Book>> GetAllAsync() => await _context.Books.Include(x => x.Users).ToListAsync();

        public async Task<Book> GetByIdAsync(int id) => await _context.Books.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<bool> UpdateAsync(UpdateBook command)
        {
            try
            {
                var isSuccess = false;
                var book = await GetByIdAsync(command.Id);

                if (book != null)
                {
                    book.Update(command.Title, command.Author, command.Description, command.ReleaseDate);

                    _context.Books.Update(book);
                    await _context.SaveChangesAsync();

                    isSuccess = true;
                }

                return isSuccess;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}