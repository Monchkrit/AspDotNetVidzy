using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.ViewModels
{
  public class RandomMovieViewModel
  {
    public Movie Movie { get; set; }
    public List<Customer> Customers { get; set; }
  }
}