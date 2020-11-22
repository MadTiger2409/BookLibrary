using BookLibrary.Infrastructure.Commands.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> IsValid(LogInUser command);

        Task<int> GetIdByLogin(string login);
    }
}