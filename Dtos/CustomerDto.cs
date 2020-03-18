using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
  public class CustomerDto
  {
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public bool IsSubscribedToNewsletter { get; set; }   
    public byte MembershipTypeId { get; set; }
    public MembershipTypeDto MembershipType { get; set; }
    public DateTime BirthDate { get; set; }
  }

}