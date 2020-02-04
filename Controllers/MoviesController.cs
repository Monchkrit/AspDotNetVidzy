
using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using System.Collections.Generic;
using Vidly.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Vidly.Controllers
{
  
  public class MoviesController : Controller
  {
    public VidlyContext _context;
    public MoviesController()
    {
      _context = new VidlyContext();
    }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }
    public ActionResult Index()
    {

      var moviesList = _context.Movies.Include(m => m.Genre).ToList();
      List<Movie> movies = new List<Movie>();

      foreach (var movie in _context.Movies)
      {
        Movie m = new Movie
        {
          Id = movie.Id,
          Name = movie.Name,
          Genre = movie.Genre,
          ReleaseDate = movie.ReleaseDate,
          DateAdded = movie.DateAdded
        };
        movies.Add(m);
      }      
      
      var viewModel = new MovieViewModel
      {
        Movies = movies
      };

      return View(viewModel);
    }
    public ActionResult New()
    {
      return View();
    }
    [Route("/movies/detail/{Id}")]
    public ActionResult Detail(int id)
    {
      var movies = _context.Movies.Include(m => m.Genre).ToList();
      Movie movie = movies.Find(m => m.Id == id);
      
      return View(movie);
    }

    public ActionResult Edit(int id)
    {
      return Content("id=" + id);
    }
    
    [Route("/movies/released/{year}/{month:regex(\\d{{2}}):range(1, 12)}")]
    public ActionResult ByReleaseYear(int year, int month)
    {
      return Content(year + "/" + month);
    }
  }
}