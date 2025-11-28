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
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork db, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Product> ProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
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

        public IActionResult Upsert(int? Id)
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

            if (Id == null || Id == 0)
            {
                // create
                return View(ProductVM);
            }
            else {
                // update
                ProductVM.Product = _unitOfWork.Product.Get(c => c.Id == Id);
                return View(ProductVM);
            }
            
        }

        [HttpPost]
        public IActionResult Create(ProductVM ProductVM, IFormFile? file)
        {
            if (file == null)
            {
                    ModelState.AddModelError("ImageUrl", "Please Upload Image for Product.");
            }
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
                /*
                 * wwwRoot path
                 * file != null
                 * new Name => GuId +extension
                 * path => images/product
                 * FileStream => create new file
                 * file.copyTo(fileStream)
                 */
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null) { 
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); 
                    string productPath = Path.Combine(wwwRootPath, "images/product");
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    ProductVM.Product.ImageUrl = $"images/product/{fileName}";

                    _unitOfWork.Product.Add(ProductVM.Product);
                    _unitOfWork.Save();
                    TempData["success"] = "Product created Successfully.";
                    return RedirectToAction("Index");
                }               
            }

            ProductVM.CategoryList = _unitOfWork.Category.GetAll().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString(),
            });

            return View(ProductVM);
        }

        [HttpPost]
        public IActionResult Upsert(ProductVM ProductVM, IFormFile? file)
        {
            //if (file == null)
            //{
            //    ModelState.AddModelError("ImageUrl", "Please Upload Image for Product.");
            //}
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
                /*
                 * wwwRoot path
                 * file != null
                 * new Name => GuId +extension
                 * path => images/product
                 * FileStream => create new file
                 * file.copyTo(fileStream)
                 */
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product");

                    // Update => ImageUrl not null => File Exist => File Delete
                    if (!string.IsNullOrEmpty(ProductVM.Product.ImageUrl)) { 
                        var oldImagePath = Path.Combine(wwwRootPath, ProductVM.Product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath)) {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    // New File Upload continue.
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    ProductVM.Product.ImageUrl = @$"\images\product\{fileName}";
                    if (ProductVM.Product.Id == 0)
                    {
                        _unitOfWork.Product.Add(ProductVM.Product);
                        _unitOfWork.Save();
                        TempData["success"] = "Product created Successfully.";
                        return RedirectToAction("Index");                        
                    }
                }

                // Update
                if (ProductVM.Product.Id != 0)
                {
                    _unitOfWork.Product.Update(ProductVM.Product);
                    TempData["success"] = "Product updated Successfully.";
                    _unitOfWork.Save();
                    return RedirectToAction("Index");
                }
                
            }

            ProductVM.CategoryList = _unitOfWork.Category.GetAll().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString(),
            });

            return View(ProductVM);
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

        #region API Calls

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> ProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = ProductList });
        }

        #endregion
    }
}
