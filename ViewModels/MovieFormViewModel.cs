using Vidly.Migrations;
using System;
using Vidly.Models;
using System.Collections.Generic;

namespace Vidly.ViewModels
{
  public class MovieFormViewModel
  {
    public IEnumerable<Genre> Genres { get; set; }
    public Movie Movie { get; set; }
    public String Heading { get; set; }
  }
}