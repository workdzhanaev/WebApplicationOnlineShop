using Microsoft.AspNetCore.Mvc;
using WebApplicationOnlineShop.Models;

namespace WebApplicationOnlineShop.Controllers
{
    public class ProductController : Controller
    {

        Product cheburek = new Product("Чебурек", "с вишней", 80000);
        Product pie = new Product("Пирожок с мясом","с кошками", 50000);
        
        public IActionResult Detalies(int ind)
        {
           if (ind == 0)
               return View(cheburek);
           return View(pie);
        }

        public IActionResult Catalog()
        {
            return View();
        }
    }
}
