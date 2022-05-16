using Microsoft.AspNetCore.Mvc;

namespace GLTechnicalTest.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
