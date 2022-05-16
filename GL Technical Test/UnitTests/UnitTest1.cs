using GLTechnicalTest.Models;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        public SimpleCalculator calculator { get; set; }

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [Test]
        public void AdditionTest()
        {
            int expectedSumOne = 2 + 2; //4
            int expectedResultOne = 4;

            Assert.AreEqual(expectedSumOne, calculator.Add(2, 2));
            Assert.AreEqual(expectedResultOne, calculator.Add(2, 2));


            int expectedSumTwo = 543 + 123; //666
            int expectedResultTwo = 666;

            Assert.AreEqual(expectedSumTwo, calculator.Add(543, 123));
            Assert.AreEqual(expectedResultTwo, calculator.Add(543, 123));
        }

        [Test]
        public void SubtractionTest()
        {
            int expectedSumOne = 6 - 3; //3
            int expectedResultOne = 3;

            Assert.AreEqual(expectedSumOne, calculator.Subtract(6, 3));
            Assert.AreEqual(expectedResultOne, calculator.Subtract(6, 3));


            int expectedSumTwo = 652 - 53; // 599
            int expectedResultTwo = 599;

            Assert.AreEqual(expectedSumTwo, calculator.Subtract(652, 53));
            Assert.AreEqual(expectedResultTwo, calculator.Subtract(652, 53));
        }

        [Test]
        public void MultiplicationTest()
        {
            int expectedSumOne = 25 * 5; //125
            int expectedResultOne = 125;

            Assert.AreEqual(expectedSumOne, calculator.Multiply(6, 3));
            Assert.AreEqual(expectedResultOne, calculator.Multiply(6, 3));


            int expectedSumTwo = 33 * 30; // 990
            int expectedResultTwo = 990;

            Assert.AreEqual(expectedSumTwo, calculator.Multiply(652, 53));
            Assert.AreEqual(expectedResultTwo, calculator.Multiply(652, 53));
        }

        [Test]
        public void DivisionTest()
        {
            float expectedSumOne = (float)7 / 2; //3.5
            float expectedResultOne = 3.5f;

            Assert.AreEqual(expectedSumOne, calculator.Divide(6, 3));
            Assert.AreEqual(expectedResultOne, calculator.Divide(6, 3));


            float expectedSumTwo = (float)658 / 8 ; // 82.25
            float expectedResultTwo = 82.25f;

            Assert.AreEqual(expectedSumTwo, calculator.Divide(652, 53));
            Assert.AreEqual(expectedResultTwo, calculator.Divide(652, 53));
        }
    }
}