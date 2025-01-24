using Microsoft.AspNetCore.Mvc;

namespace TaskTrackingSystem.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
