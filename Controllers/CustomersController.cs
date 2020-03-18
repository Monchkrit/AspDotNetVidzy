using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Vidly.ViewModels;
using System.Linq;
using AutoMapper;

namespace Vidly.Controllers
{
  public class CustomersController : Controller
  {
    public VidlyContext _context;
    private readonly IMapper _mapper;

    public CustomersController(IMapper mapper)
    {
      _context = new VidlyContext();
    }
    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }
    [Route("/customers")]
    public ActionResult Index()
    {      
      var customerList = new List<Customer>();
      var customers = _context.Customers.Include(c => c.MembershipType);
      
      foreach (var customer in customers)
      {
        Customer c = new Customer
        {
          Name = customer.Name,
          CustomerID = customer.CustomerID,
          BirthDate = customer.BirthDate,
          IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter,
          MembershipTypeId = customer.MembershipTypeId
        };
        customerList.Add(c);
      }
      var viewModel = new CustomerViewModel
      {        
        Customers = customerList
      };

      return View(viewModel);
    }

    [Route("/customers/details/{id}")]
    public ActionResult Details(int Id)
    {
      var customer = _context.Customers.Find(Id);

      return View(customer);
    }
    public ActionResult New()
    {
      var viewModel = new CustomerFormViewModel
      {
        MembershipTypes = _context.MembershipTypes.ToList()
      };

      return View("CustomerForm", viewModel);
    }
    [HttpPost]
    public ActionResult Save(Customer customer)
    {
      if (ModelState.IsValid)
      {
        if (customer.CustomerID == 0)
        {
        _context.Add(customer);
        }
        
        else
        {
          var customerInDb = _context.Customers.Single(c => c.CustomerID == customer.CustomerID);
          customerInDb.BirthDate = customer.BirthDate;
          customerInDb.CustomerID = customer.CustomerID;
          customerInDb.Name = customer.Name;
          customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
          customerInDb.MembershipTypeId = customer.MembershipTypeId;
        }
        _context.SaveChanges();

        return RedirectToAction("Index", "Customers");
      }
      else
      {
        var viewModel = new CustomerFormViewModel
        {
          Customer = customer,
          MembershipTypes = _context.MembershipTypes.ToList()
        };

        return View("CustomerForm", viewModel);
      }
    }

      
      
    public ActionResult Edit(int Id)
    {
      var customer = _context.Customers.FirstOrDefault(c => c.CustomerID == Id);

      if (customer == null)
        return NotFound();

      var viewModel = new CustomerFormViewModel
      {
        Customer = customer,
        MembershipTypes = _context.MembershipTypes.ToList()
      };
      return View("CustomerForm", viewModel);
    }
  }
}