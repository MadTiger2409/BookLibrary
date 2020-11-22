using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Commands.User
{
    public class LogInUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}