using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCHOT2.Models;

namespace MVCHOT2.Controllers
{
	public class ProductController : Controller
	{
		private ProductContext context { get; set; }

		public ProductController(ProductContext ctx) => context = ctx;

		[Route ("products/")]
		public IActionResult Index()
		{
			var products = context.Products.OrderBy(p => p.ProductName).ToList();
			ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
			return View("List", products);
		}

		[HttpGet]
		public IActionResult Add()
		{
			ViewBag.Action = "Add";
			ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
			return View("Edit", new Product());
		}


		[HttpGet]
		public IActionResult Edit(int id)
		{
			ViewBag.Action = "Edit";
			ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
			var product = context.Products.Find(id);
			return View(product);
		}

		[HttpPost]
		public IActionResult Edit(Product modifiedProduct)
		{
			if (ModelState.IsValid)
			{
				if (modifiedProduct.ProductID == 0)
				{
					context.Products.Add(modifiedProduct);
				}
				else
				{
					context.Products.Update(modifiedProduct);
				}
				context.SaveChanges();
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ViewBag.Action = (modifiedProduct.ProductID == 0) ? "Add" : "Edit";
				ViewBag.Categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
				return View(modifiedProduct);
			}
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			var product = context.Products.Find(id);
			return View(product);
		}

		[HttpPost]
		public IActionResult Delete(Product product)
		{
			context.Products.Remove(product);
			context.SaveChanges();
			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult Details(int id)
		{
			var product = context.Products.Find(id);
			return View(product);
		}


	}
}
