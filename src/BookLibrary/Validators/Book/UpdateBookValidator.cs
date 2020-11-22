using BookLibrary.Infrastructure.Commands.Book;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Validators.Book
{
    public class UpdateBookValidator : AbstractValidator<UpdateBook>
    {
        public UpdateBookValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(350)
                .WithName("Title");

            RuleFor(x => x.Author)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(150)
                .WithName("Author");

            RuleFor(x => x.ReleaseDate)
                .NotEmpty()
                .LessThan(DateTime.UtcNow.Date)
                .WithName("Release date");

            RuleFor(x => x.Description)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(500)
                .WithName("Description");
        }
    }
}