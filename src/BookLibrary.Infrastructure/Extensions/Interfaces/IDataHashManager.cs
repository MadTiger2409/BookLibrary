using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Extensions.Interfaces
{
    public interface IDataHashManager
    {
        void CalculatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);

        void CalculatePasswordHash(string password, byte[] passwordSalt, out byte[] passwordHash);

        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
    }
}