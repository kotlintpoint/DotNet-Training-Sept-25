using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> categoryList = _db.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category CategoryObj)
        {
            if(CategoryObj.Name == CategoryObj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "DisplayOrder cannot be same as Name.");
            }
            if (CategoryObj.Name != null && CategoryObj.Name.ToLower() == "test") 
            {
                ModelState.AddModelError("", "test is an invalid value.");
            }
            if (ModelState.IsValid) 
            {
                _db.Categories.Add(CategoryObj);
                _db.SaveChanges();
                TempData["success"] = "Category created Successfully.";
                return RedirectToAction("Index");
            }            
            return View();
        }

        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _db.Categories.Find(Id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category CategoryObj)
        {          
            if (ModelState.IsValid)
            {
                _db.Categories.Update(CategoryObj);
                _db.SaveChanges();
                TempData["success"] = "Category updated Successfully.";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _db.Categories.Find(Id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {           
            Category? categoryFromDb = _db.Categories.Find(Id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(categoryFromDb);
            _db.SaveChanges();
            TempData["success"] = "Category deleted Successfully.";
            return RedirectToAction("Index");
        }
    }
}
