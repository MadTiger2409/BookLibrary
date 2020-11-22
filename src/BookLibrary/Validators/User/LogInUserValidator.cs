using BookLibrary.Infrastructure.Commands.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Validators.User
{
    public class LogInUserValidator : AbstractValidator<LogInUser>
    {
        public LogInUserValidator()
        {
            RuleFor(x => x.Login)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(50)
                .WithName("Login");

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(8)
                .MaximumLength(100)
                .Must(x => ContainsSpecialCharacter(x))
                .WithName("Password")
                .WithMessage("Invalid credentials.");
        }

        private Func<string, bool> ContainsSpecialCharacter = (string password) => !string.IsNullOrEmpty(password) && password.IndexOfAny(new char[] { '!', '.', '?', '#', '$' }) != -1;
    }
}