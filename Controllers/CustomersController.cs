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
          CustomerId = customer.CustomerId
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
      var customer = _context.Customers.Find(Id.ToString());

      return View(customer);
    }
    public ActionResult New()
    {
      return View();
    }
  }
}