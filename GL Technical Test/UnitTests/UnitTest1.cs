using System.Collections.Generic;
using GLTechnicalTest.Calculator;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        public SimpleCalculator Calculator { get; set; }

        [SetUp]
        public void Setup()
        {
            Calculator = new SimpleCalculator();
        }

        [Test]
        public void AdditionTest()
        {
            int expectedSumOne = 2 + 2; //4
            int expectedResultOne = 4;

            Assert.AreEqual(expectedSumOne, Calculator.Add(2, 2));
            Assert.AreEqual(expectedResultOne, Calculator.Add(2, 2));


            int expectedSumTwo = 543 + 123; //666
            int expectedResultTwo = 666;

            Assert.AreEqual(expectedSumTwo, Calculator.Add(543, 123));
            Assert.AreEqual(expectedResultTwo, Calculator.Add(543, 123));
        }

        [Test]
        public void SubtractionTest()
        {
            int expectedSumOne = 6 - 3; //3
            int expectedResultOne = 3;

            Assert.AreEqual(expectedSumOne, Calculator.Subtract(6, 3));
            Assert.AreEqual(expectedResultOne, Calculator.Subtract(6, 3));


            int expectedSumTwo = 652 - 53; // 599
            int expectedResultTwo = 599;

            Assert.AreEqual(expectedSumTwo, Calculator.Subtract(652, 53));
            Assert.AreEqual(expectedResultTwo, Calculator.Subtract(652, 53));
        }

        [Test]
        public void MultiplicationTest()
        {
            int expectedSumOne = 25 * 5; //125
            int expectedResultOne = 125;

            Assert.AreEqual(expectedSumOne, Calculator.Multiply(25, 5));
            Assert.AreEqual(expectedResultOne, Calculator.Multiply(25, 5));


            int expectedSumTwo = 33 * 30; // 990
            int expectedResultTwo = 990;

            Assert.AreEqual(expectedSumTwo, Calculator.Multiply(33, 30));
            Assert.AreEqual(expectedResultTwo, Calculator.Multiply(33, 30));
        }

        [Test]
        public void DivisionTest()
        {
            float expectedSumOne = (float)7 / (float)2; //3.5
            float expectedResultOne = 3.5f;

            Assert.AreEqual(expectedSumOne, Calculator.Divide(7, 2));
            Assert.AreEqual(expectedResultOne, Calculator.Divide(7, 2));


            float expectedSumTwo = (float)658 / 8 ; // 82.25
            float expectedResultTwo = 82.25f;

            Assert.AreEqual(expectedSumTwo, Calculator.Divide(658, 8));
            Assert.AreEqual(expectedResultTwo, Calculator.Divide(658, 8));
        }
    }
}