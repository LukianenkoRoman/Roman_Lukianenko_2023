using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication1.Controllers
{
    public class AuthorizationFilter : IAuthorizationFilter       //here i using filter to check if user is logined
    {
        public void OnAuthorization(AuthorizationFilterContext context)  //parametrs of http context and user who try to login  
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)     //checkong if user is not logined
            {
                context.Result = new RedirectResult("/Home/PreLoger");  //if user is not autorisated moving to PreLoger
            }
        }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [TypeFilter(typeof(AuthorizationFilter))] //using filter to check if user is logined and move unlogined users to PreLoger page
        public IActionResult Index()
        { 
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]                //access to non autorisated users
        public IActionResult PreLoger()
        {
            return View();
        }

    }   
}