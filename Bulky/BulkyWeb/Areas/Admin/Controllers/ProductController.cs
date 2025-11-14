using Bulky.DataAccess.Repository;
using Bulky.Models;
using Bulky.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        //private readonly IProductRepository _db;
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork db)
        {
            _unitOfWork = db;
        }

        public IActionResult Index()
        {
            List<Product> ProductList = _unitOfWork.Product.GetAll().ToList();
            return View(ProductList);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> CategoryList = _unitOfWork.Category.GetAll().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString(),
            });
            //ViewBag.CategoryList = CategoryList;

            ProductVM ProductVM = new ProductVM
            {
                CategoryList = CategoryList,
                Product = new Product()
            };

            return View(ProductVM);
        }

        [HttpPost]
        public IActionResult Create(Product ProductObj)
        {
            //if(ProductObj.Name == ProductObj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("Name", "DisplayOrder cannot be same as Name.");
            //}
            //if (ProductObj.Name != null && ProductObj.Name.ToLower() == "test") 
            //{
            //    ModelState.AddModelError("", "test is an invalid value.");
            //}
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Add(ProductObj);
                _unitOfWork.Save();
                TempData["success"] = "Product created Successfully.";
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
            Product? ProductFromDb = _unitOfWork.Product.Get(c => c.Id == Id);
            if (ProductFromDb == null)
            {
                return NotFound();
            }
            return View(ProductFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Product ProductObj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(ProductObj);
                _unitOfWork.Save();
                TempData["success"] = "Product updated Successfully.";
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
            Product? ProductFromDb = _unitOfWork.Product.Get(c => c.Id == Id);
            if (ProductFromDb == null)
            {
                return NotFound();
            }
            return View(ProductFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {
            Product? ProductFromDb = _unitOfWork.Product.Get(c => c.Id == Id);
            if (ProductFromDb == null)
            {
                return NotFound();
            }
            _unitOfWork.Product.Remove(ProductFromDb);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted Successfully.";
            return RedirectToAction("Index");
        }
    }
}
