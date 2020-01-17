using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSaleApp.Models
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<BookLanguage> BookLanguages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
                                .HasKey(x => new { x.AuthorId, x.BookId });
            modelBuilder.Entity<BookLanguage>()
                                .HasKey(x => new { x.BookId, x.LanguageId });
            modelBuilder.Entity<AuthorBook>()
                                .HasOne(x => x.Author)
                                       .WithMany(x => x.AuthorBooks);
            modelBuilder.Entity<AuthorBook>()
                                .HasOne(x => x.Book)
                                       .WithMany(x => x.AuthorBooks);
            modelBuilder.Entity<BookLanguage>()
                                .HasOne(x => x.Book)
                                       .WithMany(x => x.BookLanguages);
            modelBuilder.Entity<BookLanguage>()
                                .HasOne(x => x.Language)
                                       .WithMany(x => x.BookLanguages);

            base.OnModelCreating(modelBuilder);
        }


    }
}
