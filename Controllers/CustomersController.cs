using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Vidly.ViewModels;
using System.Linq;

namespace Vidly.Controllers
{
  public class CustomersController : Controller
  {
    public VidlyContext _context;
    public CustomersController()
    {
      _context = new VidlyContext();
    }
    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }

    public ActionResult Index()
    {
      
      var customerList = new List<Customer>();
      var customers = _context.Customers.Include(c => c.MembershipType);
      
      foreach (var customer in customers)
      {
        Customer c = new Customer
        {
          Name = customer.Name,
          CustomerId = customer.CustomerId,
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
      var memberships = _context.MembershipTypes.ToList();


      var viewModel = new CustomerFormViewModel
      {
        MembershipTypes = memberships
      };

      return View("CustomerForm", viewModel);
    }
    [HttpPost]
    public ActionResult Save(Customer customer)
    {
      if (customer.CustomerId == 0)
        _context.Add(customer);
      else
      {
        var customerInDb = _context.Customers.Single(c => c.CustomerId == customer.CustomerId);
        customerInDb.BirthDate = customer.BirthDate;
        customerInDb.CustomerId = customer.CustomerId;
        customerInDb.Name = customer.Name;
        customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
        customerInDb.MembershipTypeId = customer.MembershipTypeId;
      }
      _context.SaveChanges();

      return RedirectToAction("Index", "Customers");
    }
    public ActionResult Edit(int Id)
    {
      var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == Id);

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