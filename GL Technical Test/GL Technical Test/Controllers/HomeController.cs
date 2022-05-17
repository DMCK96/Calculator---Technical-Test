using GLTechnicalTest.Data;
using GLTechnicalTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GLTechnicalTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {

            var resultController = new ResultController(_configuration);

            var model = new HomeViewModel
            {
                Results = resultController.GetResults()
            };

            return View(model);


        }
    }
}
