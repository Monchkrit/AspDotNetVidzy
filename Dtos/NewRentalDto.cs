using System.Collections.Generic;

namespace Vidly.Dtos
{
  public class NewRentalDto
  {
    public int CustomerID { get; set; }
    public List<int> MovieIds { get; set; }
  }
}