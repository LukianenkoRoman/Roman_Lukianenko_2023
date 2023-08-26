using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc.Filters;


namespace WebApplication1.Controllers
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

        [AllowAnonymous]              //access to non autorisated users
        public IActionResult PreLoger()
        {
            return View();
        }

    }
}