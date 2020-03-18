using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
  public class NewRentalsController : ControllerBase
  {
    [HttpPost]
    public ICollection<NewRentalDto> CreateNewRentals(NewRentalDto newRental)
    {

      var rental = new List<NewRentalDto>();

      return rental;
    }
  }
}