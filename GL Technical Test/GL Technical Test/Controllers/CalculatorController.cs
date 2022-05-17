using GLTechnicalTest.Calculator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GLTechnicalTest.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly SimpleCalculator _calculator;
        private readonly IConfiguration _configuration;


        public CalculatorController(IConfiguration configuration)
        {
            _configuration = configuration;
            _calculator = new SimpleCalculator(_configuration);
        }

        [HttpGet]
        public int GetAdditionResult(int start, int amount)
        {
            return _calculator.Add(start, amount);
        }

        [HttpGet]
        public float GetDivisionResult(int start, int amount)
        {
            return _calculator.Divide(start, amount);
        }

        [HttpGet]
        public int GetMultiplicationResult(int start, int amount)
        {
            return _calculator.Multiply(start, amount);
        }

        [HttpGet]
        public int GetSubtractionResult(int start, int amount)
        {
            return _calculator.Subtract(start, amount);
        }
    }
}
