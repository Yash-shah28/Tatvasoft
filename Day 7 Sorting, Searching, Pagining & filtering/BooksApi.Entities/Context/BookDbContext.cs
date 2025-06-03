using BooksApi.Entities.Entities;
using BooksApi.Entities.Migrations;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Entities.Context
{
    public class BookDbContext(DbContextOptions<BookDbContext> options) : DbContext(options)
    {
        public DbSet<BookDetails> BookDetails { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
