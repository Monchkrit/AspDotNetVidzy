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

    public ActionResult Index()
    {
      var customers = new List<Customer>
      {
        new Customer { Name = "Donny Buckman", Type = 0 },
        new Customer { Name = "Susan Buckman", Type = 1 }
      };
      // // using (VidlyContext context = new VidlyContext())
      //   {
      //     var c = context.Customers;
      //   }
      var viewModel = new CustomerViewModel
      {        
        Customers = customers
      };

      return View(viewModel);
    }

    [Route("/customers/details/{type}")]
    public ActionResult Details(int type)
    {
      Customer customer = new Customer { Name = "Donny Buckman", Type = 0 };
      Customer customer1 = new Customer { Name = "Susan Buckman", Type = 1 };

      if (type == 0)
        return View(customer);
      if (type == 1)
        return View(customer1);

      return View();
    }
    
    private List<Customer> GetCustomers()
    {
      List<Customer> customers = new List<Customer>();
          Customer customer = new Customer { Name = "Donny Buckman", Type = 0 };
          Customer customer1 = new Customer { Name = "Susan Buckman", Type = 1 };
          customers.Add(customer);
          customers.Add(customer1);

      return customers;
    }
  }
}