using Bangazon.Data;
using Bangazon.Models;
using Bangazon.Models.ProductViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.ViewComponents
{
    public class ProductCountViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductCountViewComponent(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new ProductCountViewModel();

            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user == null)
            {
                //because default integer is zero, just return the viewModel without adding to product count if not logged in
                return View(viewModel);
            }

            var productCount = _context.Product.Where(prod => prod.UserId == user.Id).Count();

            viewModel.ProductCount = productCount;

            return View(viewModel);
        }
    }
}
