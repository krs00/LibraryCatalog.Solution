using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryCatalog.Models
{
  public class Author
  {
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Book> Books { get; set; } // NAVIGATION PROPERTY
  }
}