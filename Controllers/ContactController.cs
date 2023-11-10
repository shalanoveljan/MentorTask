using Microsoft.AspNetCore.Mvc;

namespace MentorTemplate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
