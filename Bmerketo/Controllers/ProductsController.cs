using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bmerketo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin, ProductManager")]
        public IActionResult Product()
        {
            return View();
        }
    }
}