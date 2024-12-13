using Microsoft.AspNetCore.Mvc;

namespace mvc_1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
