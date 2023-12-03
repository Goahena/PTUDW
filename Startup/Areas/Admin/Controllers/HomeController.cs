using Microsoft.AspNetCore.Mvc;
using Startup.Utilities;

namespace Startup.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (!Functions.IsLogin())
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
        public IActionResult Logout()
        {
            Functions._UserID = 0;
            Functions._UserName = String.Empty;
            Functions._Email = String.Empty;
            Functions._Message = String.Empty;
            Functions._MessageEmail = String.Empty;

            return RedirectToAction("Index", "Home");
        }
    }
}
