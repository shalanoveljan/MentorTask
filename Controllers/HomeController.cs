using Microsoft.AspNetCore.Mvc;

namespace MentorTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
