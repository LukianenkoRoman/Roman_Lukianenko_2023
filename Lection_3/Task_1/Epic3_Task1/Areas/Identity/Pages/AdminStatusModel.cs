using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AdminStatusModel : PageModel
    {
        public bool IsAdmin { get; set; }    //property to chek is user admin

        public void OnGet()                  //OnGet method is called on http get to page
        {
            IsAdmin = IfAdmin();             //Admin sttatus audit
            ViewData["IsAdmin"] = IsAdmin;   
        }

        public bool IfAdmin() 
        {
            return User.IsInRole("Admin");  //bool method to audit if user have admin role
        }
    }
}
