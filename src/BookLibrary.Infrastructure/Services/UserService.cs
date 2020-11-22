using BookLibrary.Infrastructure.Commands.User;
using BookLibrary.Infrastructure.Dal;
using BookLibrary.Infrastructure.Extensions.Interfaces;
using BookLibrary.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly LibraryContext _context;
        private readonly IDataHashManager _dataHashManager;

        public UserService(LibraryContext context, IDataHashManager dataHashManager)
        {
            _context = context;
            _dataHashManager = dataHashManager;
        }

        public async Task<bool> IsValid(LogInUser command)
        {
            try
            {
                var isValid = false;
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Login == command.Login);

                if (_dataHashManager.VerifyPasswordHash(command.Password, user.PasswordHash, user.Salt) == true)
                    isValid = true;

                return isValid;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<int> GetIdByLogin(string login)
        {
            try
            {
                return await _context.Users.Where(x => x.Login == login).Select(x => x.Id).SingleOrDefaultAsync();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}