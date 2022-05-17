using GLTechnicalTest.Calculator.Interfaces;
using GLTechnicalTest.Data;
using GLTechnicalTest.Models;

namespace GLTechnicalTest.Calculator
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            using (var db = new CalculatorContext())
            {

                var result = start + amount;

                var resultModel = new ResultModel
                {
                    Start = start,
                    Amount = amount,
                    Result = result,
                    Method = "Add",
                    Readable = $"{start} + {amount} = {result}"
                };

                db.Results.Add(resultModel);


                return result;
            }
            
        }

        public float Divide(int start, int amount)
        {
            using (var db = new CalculatorContext())
            {

                var result = start / amount;

                var resultModel = new ResultModel
                {
                    Start = start,
                    Amount = amount,
                    Result = result,
                    Method = "Divide",
                    Readable = $"{start} / {amount} = {result}"
                };

                db.Results.Add(resultModel);


                return result;
            }
        }

        public int Multiply(int start, int amount)
        {
            using (var db = new CalculatorContext())
            {

                var result = start + amount;

                var resultModel = new ResultModel
                {
                    Start = start,
                    Amount = amount,
                    Result = result,
                    Method = "Multiply",
                    Readable = $"{start} x {amount} = {result}"
                };

                db.Results.Add(resultModel);


                return result;
            }
        }

        public int Subtract(int start, int amount)
        {
            using (var db = new CalculatorContext())
            {

                var result = start + amount;

                var resultModel = new ResultModel
                {
                    Start = start,
                    Amount = amount,
                    Result = result,
                    Method = "Subtract",
                    Readable = $"{start} - {amount} = {result}"
                };

                db.Results.Add(resultModel);


                return result;
            }
        }
    }
}
