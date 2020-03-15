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
      var movies = from m in _context.Movies.Include(g => g.Genre)
        select new MovieDto()
        {
          Id = m.Id,
          Name = m.Name,
          ReleaseDate = m.ReleaseDate,
          DateAdded = m.DateAdded,
          Genre = m.Genre
        };

      return movies;
    }

    [Route("/api/movies/{Id}")]
    public MovieDto GetMovieDto(int Id)
    {
      var movie = new MovieDto();
      var m = _context.Movies.SingleOrDefault(m => m.Id == Id);
      
      movie.Id = m.Id;
      movie.Name = m.Name;
      movie.DateAdded = m.DateAdded;
      movie.ReleaseDate = m.ReleaseDate;
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
        DateAdded = movie.DateAdded
      };
      return dto;
    }

    [HttpPut]
    [Route("/api/movies/edit/{Id}")]
    public void UpdateMovieDto(int Id, MovieDto movieDto)
    {
      if (!ModelState.IsValid)
        throw new HttpResponseException();

      var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == Id);

      if (movieInDb == null)
        throw new HttpResponseException();
      movieInDb.Id = movieDto.Id;
      movieInDb.Name = movieDto.Name;
      movieInDb.GenreId = movieDto.GenreId;
      movieInDb.ReleaseDate = movieDto.ReleaseDate;

      _context.SaveChanges();

      var dto = new MovieDto
      {
        Id = movieInDb.Id,
        Name = movieInDb.Name,
        GenreId = movieInDb.GenreId,
        ReleaseDate = movieInDb.ReleaseDate
      };
      return 
    }

    [Route("/api/movies/delete/{id}")]
    public void DeleteMovie(int Id)
    {
      var movie = _context.Movies.SingleOrDefault(m => m.Id == Id);
      _context.Remove(movie);
      _context.SaveChanges();
    }

    public class HttpResponseException : Exception
    {
      public int Status { get; set; } = 500;
      public object Value { get; set; }
    }
  }
}