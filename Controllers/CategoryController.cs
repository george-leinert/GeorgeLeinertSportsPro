using Microsoft.AspNetCore.Mvc;
using MVCHOT2.Models;

namespace MVCHOT2.Controllers
{
    public class CategoryController : Controller
    {
        private ProductContext context { get; set; }

        public CategoryController(ProductContext ctx) => context = ctx;

		[Route("categories/")]
		public IActionResult Index()
        {
            var categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            return View("List", categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Category());
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var category = context.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category modifiedCategory)
        {
            if (ModelState.IsValid)
            {
                if (modifiedCategory.CategoryID == 0)
                {
                    context.Categories.Add(modifiedCategory);
                }
                else
                {
                    context.Categories.Update(modifiedCategory);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (modifiedCategory.CategoryID == 0) ? "Add" : "Edit";
                return View(modifiedCategory);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = context.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
