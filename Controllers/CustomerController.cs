using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCHOT2.Models;

namespace MVCHOT2.Controllers
{
    public class CustomerController : Controller
    {
        private ProductContext context { get; set; }

        public CustomerController(ProductContext ctx) => context = ctx;

		[Route("customers/")]
		public IActionResult Index()
        {
            var customers = context.Customers.OrderBy(c => c.CustomerFirstName).ToList();
            return View("List", customers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Customer());
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var customer = context.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer modifiedCustomer)
        {
            if (ModelState.IsValid)
            {
                if (modifiedCustomer.CustomerID == 0)
                {
                    context.Customers.Add(modifiedCustomer);
                }
                else
                {
                    context.Customers.Update(modifiedCustomer);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (modifiedCustomer.CustomerID == 0) ? "Add" : "Edit";
                return View(modifiedCustomer);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


    }
}
