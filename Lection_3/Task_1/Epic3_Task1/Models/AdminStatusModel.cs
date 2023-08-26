using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Models
{
    [Authorize(Roles = "Admin")]          
    public class AdminStatusModel 
    {

    }
}

