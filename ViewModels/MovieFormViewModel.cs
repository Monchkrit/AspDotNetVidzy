using Vidly.Migrations;
using System;
using Vidly.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
  public class MovieFormViewModel
  {
    public IEnumerable<Genre> Genres { get; set; }
    public int? Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public Genre Genre { get; set; }
    public int? GenreId { get; set; }

    [Required]
    public DateTime ReleaseDate { get; set; }

    [Required]
    public short? Stock { get; set; }
    public String Heading { get; set; }


    public MovieFormViewModel()
    {
        Id = 0;
    }
    
    public MovieFormViewModel(Movie movie)
    {
      Id = movie.Id;
      Name = movie.Name;
      ReleaseDate = movie.ReleaseDate;
      Stock = movie.Stock;
      GenreId = movie.GenreId;
    }
  }
}