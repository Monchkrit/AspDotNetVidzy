
using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using System.Collections.Generic;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
    public ActionResult Random()
    {
      var movie = new Movie() { Name = "Shrek!" };
      var customers = new List<Customer>
      {
        new Customer { Name = "Customer 1" },
        new Customer { Name = "Customer 2" }
      };

      var viewModel = new RandomMovieViewModel
      {
        Movie = movie,
        Customers = customers
      };

      return View(viewModel);
    }

    public ActionResult Edit(int id)
    {
      return Content("id=" + id);
    }
    public ActionResult Index()
    {
      var movies = new List<Movie>
      {
        new Movie { Name = "Shreck!" },
        new Movie { Name = "Wallie" }
      };
      var viewModel = new MovieViewModel
      {
        Movies = movies
      };

      return View(viewModel);
    }

    [Route("/movies/released/{year}/{month:regex(\\d{{2}}):range(1, 12)}")]
    public ActionResult ByReleaseYear(int year, int month)
    {
      return Content(year + "/" + month);
    }
  }
}