using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using System.Collections.Generic;
using Vidly.ViewModels;

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
      var viewModel = new CustomerViewModel
      {
        Customers = customers
      };

      return View(viewModel);
    }

    [Route("/customers/details/{type}")]
    public ActionResult Details(int type)
    {
      Customer customer = new Customer { Name = "Donny Buckman" };
      Customer customer1 = new Customer { Name = "Susan Buckman" };

      if (type == 0)
        return View(customer);
      if (type == 1)
        return View(customer1);

      return View();
    }
  }
}