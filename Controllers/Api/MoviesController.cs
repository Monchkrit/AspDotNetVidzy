using Microsoft.AspNetCore.Mvc;
using Vidly.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Vidly.Models;
using System;

namespace Vidly.Controllers.Api
{
  [ApiController]
  [Route("[controller]")]
  public class MoviesController : ControllerBase
  {
    VidlyContext _context;
    public MoviesController()
    {
      _context = new VidlyContext();
    }
    [Route("/api/movies")]
    public IEnumerable<MovieDto> Get()
    {
      var movies = from m in _context.Movies
        select new MovieDto()
        {
          Name = m.Name,
          ReleaseDate = m.ReleaseDate,
          DateAdded = m.DateAdded,
          GenreId = m.GenreId,
          Stock = m.Stock
        };

      return movies;
    }

    [Route("/api/movies/{Id}")]
    public MovieDto GetMovieDto(int Id)
    {
      var movie = new MovieDto();
      var m = _context.Movies.SingleOrDefault(m => m.Id == Id);
      
      movie.Name = m.Name;
      movie.DateAdded = m.DateAdded;
      movie.ReleaseDate = m.ReleaseDate;
      movie.Stock = m.Stock;
      movie.GenreId = m.GenreId;

      return movie;
    }

    [HttpPost]
    [Route("/api/movies/new")]
    public MovieDto CreateMovieDto(Movie movie)
    {
      if (!ModelState.IsValid)
        throw new HttpResponseException();

      _context.Movies.Add(movie);
      _context.SaveChanges();

      var dto = new MovieDto()
      {
        Name = movie.Name,
        GenreId = movie.GenreId,
        ReleaseDate = movie.ReleaseDate,
        DateAdded = movie.DateAdded,
        Stock = movie.Stock
      };
      return dto;
    }

    [HttpPut]
    [Route("/api/movies/update")]
    public MovieDto UpdateMovieDto(int Id, Movie movie)
    {
      if (!ModelState.IsValid)
        throw new HttpResponseException();

      var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == Id);

      if (movie == null)
        throw new HttpResponseException();

      movieInDb.Name = movie.Name;
      movieInDb.GenreId = movie.GenreId;
      movieInDb.DateAdded = movie.DateAdded;
      movieInDb.ReleaseDate = movie.ReleaseDate;
      movieInDb.Stock = movie.Stock;

      _context.SaveChanges();

      var dto = new MovieDto
      {
        Name = movieInDb.Name,
        Stock = movieInDb.Stock
      };

      return dto;
    }

    public class HttpResponseException : Exception
    {
      public int Status { get; set; } = 500;
      public object Value { get; set; }
    }
  }
}