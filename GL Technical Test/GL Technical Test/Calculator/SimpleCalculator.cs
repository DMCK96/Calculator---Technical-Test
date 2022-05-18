using GLTechnicalTest.Calculator.Interfaces;
using GLTechnicalTest.Data;
using GLTechnicalTest.Models;
using Microsoft.Extensions.Configuration;

namespace GLTechnicalTest.Calculator
{
    public class SimpleCalculator : ISimpleCalculator
    {
        private readonly IConfiguration _configuration;
        private bool _mocked;

        public SimpleCalculator(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Empty constructor is only to be used with unit test.
        public SimpleCalculator()
        {
            _mocked = true;
        }

        public int Add(int start, int amount)
        {
            var result = start + amount;

            if (!_mocked)
            {
                using (var dbContext = new CalculatorContext(_configuration.GetValue<string>("ConnectionStrings:CalculatorContext")))
                {
                    var resultModel = new ResultModel
                    {
                        Start = start,
                        Amount = amount,
                        Result = result,
                        Method = "Add",
                        Readable = $"{start} + {amount} = {result}"
                    };

                    dbContext.Results.Add(resultModel);
                    dbContext.SaveChanges();
                }
            }
            

            return result;
            
        }

        public float Divide(int start, int amount)
        {
            var result = start / amount;

            if (!_mocked)
            {
                using (var dbContext = new CalculatorContext(_configuration.GetValue<string>("ConnectionStrings:CalculatorContext")))
                {
                    var resultModel = new ResultModel
                    {
                        Start = start,
                        Amount = amount,
                        Result = result,
                        Method = "Divide",
                        Readable = $"{start} / {amount} = {result}"
                    };

                    dbContext.Results.Add(resultModel);
                    dbContext.SaveChanges();
                }
            }
            

            return result;
        }

        public int Multiply(int start, int amount)
        {
            var result = start + amount;

            if (!_mocked)
            {
                using (var dbContext = new CalculatorContext(_configuration.GetValue<string>("ConnectionStrings:CalculatorContext")))
                {
                    var resultModel = new ResultModel
                    {
                        Start = start,
                        Amount = amount,
                        Result = result,
                        Method = "Multiply",
                        Readable = $"{start} x {amount} = {result}"
                    };

                    dbContext.Results.Add(resultModel);
                    dbContext.SaveChanges();
                }
            }

            return result;
        }

        public int Subtract(int start, int amount)
        {

            var result = start + amount;

            if (!_mocked)
            {
                using (var dbContext = new CalculatorContext(_configuration.GetValue<string>("ConnectionStrings:CalculatorContext")))
                {
                    var resultModel = new ResultModel
                    {
                        Start = start,
                        Amount = amount,
                        Result = result,
                        Method = "Subtract",
                        Readable = $"{start} - {amount} = {result}"
                    };

                    dbContext.Results.Add(resultModel);
                    dbContext.SaveChanges();
                }
            }
            

            return result;
        }
    }
}
