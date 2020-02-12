using System;

namespace Vidly.Dtos
{
  public class MovieDto
  {
    public string Name { get; set; }
    public int GenreId { get; set; }
    public DateTime ReleaseDate { get; set; }    
    public DateTime DateAdded { get; set; }
    public short Stock { get; set; }
  }
}