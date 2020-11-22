using BookLibrary.Domain.Models;
using BookLibrary.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Infrastructure.Dal
{
    public class LibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public LibraryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Books)
                .WithMany(y => y.Users)
                .UsingEntity<Reservation>(
                        x => x.HasOne(xs => xs.Book).WithMany(),
                        x => x.HasOne(xs => xs.User).WithMany());

            modelBuilder.Entity<User>()
                .HasData(CreateDefaultUser());
        }

        private User CreateDefaultUser()
        {
            DataHashManager manager = new DataHashManager();
            manager.CalculatePasswordHash("Admin1234!", out var passwordHash, out var passwordSalt);

            return new User { Id = 1, Login = "Admin", PasswordHash = passwordHash, Salt = passwordSalt };
        }
    }
}