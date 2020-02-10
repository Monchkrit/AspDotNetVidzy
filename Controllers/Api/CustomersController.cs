using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
  [ApiController]
  [Route("[controller]")]
  public class CustomersController : ControllerBase
  {
    private VidlyContext _context;
    public CustomersController()
    {
      _context = new VidlyContext();
    }
    
    [HttpGet]
    [Route("/api/customers")]
    public IEnumerable<CustomerDto> GetCustomers()
    { 
      var customers = from c in _context.Customers
          select new CustomerDto()
          {
            CustomerId = c.CustomerId,
            IsSubscribedToNewsletter = c.IsSubscribedToNewsletter,
            MembershipTypeId = c.MembershipTypeId,
            Name = c.Name,
            BirthDate = c.BirthDate
          };
      return customers;
    }

    [HttpGet]
    [Route("/api/customer/{id}")]
    public CustomerDto GetCustomer(int Id)
    {
      var c = _context.Customers.SingleOrDefault(c => c.CustomerId == Id);

      var customer =  new CustomerDto
      {
        CustomerId = c.CustomerId,
        IsSubscribedToNewsletter = c.IsSubscribedToNewsletter,
        MembershipTypeId = c.MembershipTypeId,
        Name = c.Name,
        BirthDate = c.BirthDate
      };

      if (c == null)
      {
        throw new HttpResponseException();
      }

      return customer;
    }
    [HttpPost]
    [Route("/api/customers/new")]
    public CustomerDto CreateCustomer(Customer customer)
    {
      if (!ModelState.IsValid)
        throw new HttpResponseException();


        _context.Customers.Add(customer);
        _context.SaveChanges();

        var dto = new CustomerDto()
        {
          Name = customer.Name,
          CustomerId = customer.CustomerId,
          BirthDate = customer.BirthDate,
          IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter,
          MembershipTypeId = customer.MembershipTypeId
        };

        return dto;
    }

    [HttpPut]
    [Route("/api/customers/update")]
    public void UpdateCustomer(int Id, Customer customer)
    {
      if (!ModelState.IsValid)
        throw new HttpResponseException();

      var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerId == Id);

      if (customer == null)
        throw new HttpResponseException();

      customerInDb.Name = customer.Name;
      customerInDb.BirthDate = customer.BirthDate;
      customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
      customerInDb.MembershipTypeId = customer.MembershipTypeId;

      _context.SaveChanges();

    }

    [HttpDelete]
    [Route("/api/customers/delete")]
    public void DeleteCustomer(int Id)
    {
      var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerId == Id);

      if (customerInDb == null)
        throw new HttpResponseException();

      _context.Customers.Remove(customerInDb);
      _context.SaveChanges();
    }
    public class HttpResponseException : Exception
    {
      public int Status { get; set; } = 500;
      public object Value { get; set; }
    }
  }
}
