using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GLTechnicalTest.Data;

namespace GLTechnicalTest.Controllers
{
    public class ResultController : Controller
    {
        private readonly CalculatorContext _context;

        public ResultController(CalculatorContext context)
        {
            _context = context;
        }

        // GET: Result
        public async Task<IActionResult> Index()
        {
            return View(await _context.Results.ToListAsync());
        }

        private bool ResultModelExists(int id)
        {
            return _context.Results.Any(e => e.Id == id);
        }
    }
}
