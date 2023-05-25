using Microsoft.EntityFrameworkCore;

namespace LibraryCatalog.Models
{
  public class LibraryCatalogContext : DbContext
  {
    // public DbSet<Book> Books { get; set; }
    
    public LibraryCatalogContext(DbContextOptions options) : base(options) { }
  }
}