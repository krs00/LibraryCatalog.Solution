using Microsoft.EntityFrameworkCore;

namespace LibraryCatalog.Models
{
  public class LibraryCatalogContext : DbContext
  {
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    
    public LibraryCatalogContext(DbContextOptions options) : base(options) { }
  }
}