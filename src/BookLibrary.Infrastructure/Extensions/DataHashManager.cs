﻿using BookLibrary.Infrastructure.Extensions.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BookLibrary.Infrastructure.Extensions
{
    public class DataHashManager : IDataHashManager
    {
        public void CalculatePasswordHash(string password, out byte[] passwordHash,
            out byte[] passwordSalt)
        {
            var hmac512 = new HMACSHA512();
            passwordSalt = hmac512.Key;
            passwordHash = hmac512.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public void CalculatePasswordHash(string password, byte[] passwordSalt,
            out byte[] passwordHash)
        {
            var hmac512 = new HMACSHA512(passwordSalt);
            passwordHash = hmac512.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public bool VerifyPasswordHash(string password, byte[] passwordHash,
            byte[] passwordSalt)
        {
            var hmac512 = new HMACSHA512(passwordSalt);
            var computedHash = hmac512.ComputeHash(Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < passwordHash.Length; i++)
                if (computedHash[i] != passwordHash[i]) return false;
            return true;
        }
    }
}