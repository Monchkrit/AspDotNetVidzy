using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
  public class Movie
  {
    
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public Genre Genre { get; set; }
    public int GenreId { get; set; }
    public DateTime ReleaseDate { get; set; }    
    public DateTime DateAdded { get; set; }
    public short Stock { get; set; }
  }
}