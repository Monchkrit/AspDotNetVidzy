
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
          DateAdded = movie.DateAdded,
          Stock = movie.Stock
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
      string source = "New Movie";

      var viewModel = new MovieFormViewModel
      {
        Genres = _context.Genres.ToList(),
        Heading = source
      };

      return View("MovieForm", viewModel);
    }

    [HttpPost]
    public ActionResult Save(Movie movie)
    {
      if (ModelState.IsValid)
      {
        if (movie.Id == 0)
        {
          _context.Movies.Add(movie);
        }
        else
        {
          var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
          movieInDb.GenreId = movie.GenreId;
          movieInDb.Name = movie.Name;
          movieInDb.ReleaseDate = movie.ReleaseDate;
          movieInDb.Stock = movie.Stock;
        }

        _context.SaveChanges();

        return RedirectToAction("Index", "Movies");
      }
    
      else
      {
        var source = "Try Again";
        var viewModel = new MovieFormViewModel(movie)
        {
          Genres = _context.Genres.ToList(),
          Heading = source
        };

        return View("MovieForm", viewModel);
      }      
    }
    public ActionResult Edit(int Id)
    {
      var movie = _context.Movies.Single(m => m.Id == Id);
      string source = "Edit Movie";

      var viewModel = new MovieFormViewModel(movie)
      {        
        Genres = _context.Genres.ToList(),
        Heading = source
      };

      return View("MovieForm", viewModel);
    }
    [Route("/movies/detail/{Id}")]
    public ActionResult Detail(int id)
    {
      var movies = _context.Movies.Include(m => m.Genre).ToList();
      Movie movie = movies.Find(m => m.Id == id);
      
      return View(movie);
    }
  }
}