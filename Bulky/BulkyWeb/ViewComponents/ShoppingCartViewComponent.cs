using Bulky.DataAccess.Repository;
using Bulky.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BulkyWeb.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShoppingCartViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            if (claimIdentity.IsAuthenticated) {
                var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
                if (userId != null)
                {
                    if (HttpContext.Session.GetInt32(SD.SessionCart) == null)
                    {
                        HttpContext.Session.SetInt32(SD.SessionCart,
                        _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId).Count());
                    }
                    return View(HttpContext.Session.GetInt32(SD.SessionCart));
                }             
            }                
            HttpContext.Session.Clear();
            return View(0);           
            
        }
    }
}
