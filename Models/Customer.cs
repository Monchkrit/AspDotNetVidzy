using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
  public class Customer
  {
    [Key]
    public string CustomerId { get; set; }
    public int Type { get; set; }
    [Required]
    public string Name { get; set; }
    public bool IsSubscribedToNewsletter { get; set; }
    public MembershipType MembershipType { get; set; }
    public byte MembershipTypeId { get; set; }
  }
}