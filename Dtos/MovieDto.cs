using System;

namespace Vidly.Dtos
{
  public class MovieDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int GenreId { get; set; }
    public Genre Genre { get; set; }
    public DateTime ReleaseDate { get; set; }    
    public DateTime DateAdded { get; set; }
  }
}