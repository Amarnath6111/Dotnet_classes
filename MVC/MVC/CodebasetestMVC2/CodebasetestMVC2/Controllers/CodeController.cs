using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodebasetestMVC2.Models;
namespace CodebasetestMVC2.Controllers
{
    public class CodeController : Controller
    {
        
        private NorthWindEntities1 db = new NorthWindEntities1(); 
        public ActionResult CustomersInGermany()
        {
            var germanCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanCustomers);
        }
        public ActionResult CustomerDetailsWithOrderId()
        {
            var customerId = db.Orders.FirstOrDefault(od => od.OrderID == 10248)?.Customer;
            var customerDetails = db.Customers.FirstOrDefault(c => c.CustomerID == customerId.ToString());
            return View(customerDetails);
        }
    }
}