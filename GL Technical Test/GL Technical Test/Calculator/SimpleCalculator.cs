using GLTechnicalTest.Calculator.Interfaces;

namespace GLTechnicalTest.Calculator
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public float Divide(int start, int amount)
        {
            return (float)start / amount;
        }

        public int Multiply(int start, int amount)
        {
            return start * amount;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}
