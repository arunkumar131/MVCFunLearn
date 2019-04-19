﻿using MVCFunLearn.Models;
using MVCFunLearn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCFunLearn.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing);
            _context.Dispose();
        }
        // GET: Customers
        public ViewResult Index()
        {
            //var customers = GetCustomers();
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        //Customers/Details/id
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(C => C.MembershipType ).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        #region Hard Code used initiallly
        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer{ Id = 1, Name = "Arun Kumar" },
        //        new Customer{ Id = 2, Name = "Nupur Bala" }
        //    };
        //}
        #endregion
    }
}