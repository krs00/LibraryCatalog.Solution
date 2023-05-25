using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryCatalog.Models
{
  public class Book
  {
    public int BookId { get; set; }
    public string Title { get; set; } 
    public string Genre { get; set; }
    public string Publisher { get; set; }
    public bool Availability { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "Book must have due date!")]
    public DateTime DueDate { get; set; }
    public List<Author> Author {  get; set; } // NAVIGATION PROPERTY  
    public Author Author { get; set; } // REFERENCE NAVIGATION PROPERTY


  }
}