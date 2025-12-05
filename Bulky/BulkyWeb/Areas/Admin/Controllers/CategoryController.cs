using Bulky.DataAccess.Repository;
using Bulky.Models;
using Bulky.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        //private readonly ICategoryRepository _db;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork db)
        {
            _unitOfWork = db;
        }

        public IActionResult Index()
        {
            List<Category> categoryList = _unitOfWork.Category.GetAll().ToList();
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
                _unitOfWork.Category.Add(CategoryObj);
                _unitOfWork.Save();
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
            Category? categoryFromDb = _unitOfWork.Category.Get(c => c.Id == Id);
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
                _unitOfWork.Category.Update(CategoryObj);
                _unitOfWork.Save();
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
            Category? categoryFromDb = _unitOfWork.Category.Get(c => c.Id == Id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {           
            Category? categoryFromDb = _unitOfWork.Category.Get(c => c.Id == Id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Remove(categoryFromDb);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted Successfully.";
            return RedirectToAction("Index");
        }
    }
}
