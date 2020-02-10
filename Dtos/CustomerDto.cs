using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
  public class CustomerDto
  {
    public int CustomerId { get; set; }
      
    [Required]
    public string Name { get; set; }
    public bool IsSubscribedToNewsletter { get; set; }   
    public byte MembershipTypeId { get; set; }
    public DateTime BirthDate { get; set; }
  }

}