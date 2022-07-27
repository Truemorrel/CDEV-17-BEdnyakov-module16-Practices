using NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_16_7_1;

namespace Task_16_7_1.Tests
{
    public class CalculatorTests
    {
        Calculator _calculator;
        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void AdditionMustRecurnCorrectValue()
        {
            Assert.AreEqual(4, _calculator.Addition(1, 3));
        }

        [Test]
        public void SubstractionMustRecurnCorrectValue()
        {
            Assert.AreEqual(3, _calculator.Subtraction(8, 5));
        }

        [Test]
        public void MultiplicationMustRecurnCorrectValue()
        {
            Assert.AreEqual(40, _calculator.Multiplication(8, 5));
        }

        [Test]
        public void DivisionMustRecurnCorrectValue()
        {
            Assert.AreEqual(2, _calculator.Division(14, 5));
        }
    }
}
