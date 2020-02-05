using Vidly.Models;
using System.Collections.Generic;

namespace Vidly.ViewModels
{
  public class MovieViewModel
  {
    public List<Movie> Movies { get; set; }
    public List<Genre> Genres { get; set; }
  }
}