using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
  public class Movie
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public Genre Genre { get; set; }
    public int GenreId { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime DateAdded { get; set; }
  }
}