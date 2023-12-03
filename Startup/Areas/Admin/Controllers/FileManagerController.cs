using Microsoft.AspNetCore.Mvc;
using Startup.Utilities;

namespace Startup.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/file-manager")]
    public class FileManagerController : Controller
    {
        public IActionResult Index()
        {
            if (!Functions.IsLogin())
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
