using Microsoft.AspNetCore.Mvc;

namespace TaskTrackingSystem.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
