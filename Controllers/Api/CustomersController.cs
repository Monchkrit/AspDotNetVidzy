using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Vidly.Controllers.Api
{
  public class CustomersController : ControllerBase
  {
    private VidlyContext _context;
    private readonly IMapper _mapper;

    public CustomersController(IMapper mapper)
    {
      _context = new VidlyContext();
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    
    [HttpGet]
    [Route("/api/customers")]
    public IEnumerable<CustomerDto> GetCustomers()
    { 
      var customers = from c in _context.Customers
                .Include(c => c.MembershipType)
                .ToList()
          select new CustomerDto()
          {
            CustomerID = c.CustomerID,
            IsSubscribedToNewsletter = c.IsSubscribedToNewsletter,
            MembershipTypeId = c.MembershipTypeId,
            MembershipType = _mapper.Map<MembershipType, MembershipTypeDto>(c.MembershipType),
            Name = c.Name,
            BirthDate = c.BirthDate
          };
      return customers;
    }

    [HttpGet]
    [Route("/api/customer/{id}")]
    public CustomerDto GetCustomer(int Id)
    {
      var c = _context.Customers.SingleOrDefault(c => c.CustomerID == Id);

      var customer =  new CustomerDto
      {
        CustomerID = c.CustomerID,
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
          CustomerID = customer.CustomerID,
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

      var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerID == Id);

      if (customer == null)
        throw new HttpResponseException();

      customerInDb.Name = customer.Name;
      customerInDb.BirthDate = customer.BirthDate;
      customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
      customerInDb.MembershipTypeId = customer.MembershipTypeId;

      _context.SaveChanges();

    }

    [HttpDelete]
    [Route("/api/customers/delete/{Id}")]
    public void DeleteCustomer(int Id)
    {
      var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerID == Id);

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
