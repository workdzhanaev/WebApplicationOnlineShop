using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationOnlineShop.Models;

namespace WebApplicationOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
