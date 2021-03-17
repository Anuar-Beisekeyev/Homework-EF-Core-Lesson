using HomeworkEFCoreLesson.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEFCoreLesson.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorAndBook> AuthorsAndBooks { get; set; }
        public DbSet<Extradition> Extraditions { get; set; }
        public DbSet<Reader> Readers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3S2N5VP; Database=CentralLibrary; Trusted_Connection = true;");
        }
    }
}
