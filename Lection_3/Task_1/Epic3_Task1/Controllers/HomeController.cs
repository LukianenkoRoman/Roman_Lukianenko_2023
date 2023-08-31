using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Humanizer;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public List<UserModel> UserData = new List<UserModel>  //collection that conteins data of user
        {
            new UserModel { Id = 1, Email = "random@gmail.com", Password = "randompassword", IsAdmin = false },   //creation UserModel objects
            new UserModel { Id = 2, Email = "randomadmin@gmail.com", Password = "adminpassword", IsAdmin = true }
        };

        [HttpGet]                                             //method responds to get requests
        public IActionResult Index(string Email)         
        {
            if (UserData.Exists(user => user.Email == Email))      //cheking if list conteins email of useer 
            {
                return View();                                    
            }
            else
            {
                return RedirectToAction("PreLoger");             
            }
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