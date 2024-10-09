using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSystem.WEB.Areas.Client.Controllers
{
    [Area("Client")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
