using Microsoft.EntityFrameworkCore;
using Piece_of_Art_Mall.Models;

namespace Piece_of_Art_Mall.AppDbContextFolder
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<LoyalityCard> LoyalityCard { get; set; }
        public DbSet<PieceOfArt> PieceOfArt { get; set; }

    }
}
