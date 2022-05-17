using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GLTechnicalTest.Data;
using GLTechnicalTest.Models;
using Microsoft.Extensions.Configuration;

namespace GLTechnicalTest.Controllers
{
    public class ResultController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly CalculatorContext _context;

        public ResultController(IConfiguration configuration)
        {
            _configuration = configuration;
            _context = new CalculatorContext(_configuration.GetValue<string>("ConnectionStrings:CalculatorContext"));
        }

        // GET: Result
        public async Task<IActionResult> Index()
        {
            return View(await _context.Results.ToListAsync());
        }

        public List<ResultModel> GetResults()
        {
            return ResultModelExists() ? _context.Results.ToList() : new List<ResultModel>();
        }

        private bool ResultModelExists()
        {
            return _context.Results.Any();
        }
    }
}
