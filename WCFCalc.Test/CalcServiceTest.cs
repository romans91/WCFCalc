using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WCFCalcService;

namespace WCFCalc.Test
{
    [TestFixture]
    public class CalcServiceTest
    {
        private CalcService service;

        [SetUp]
        public void SetUp()
        {
            service = new CalcService();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual("20", service.PerformOperation("5", "15", '+'));
        }

        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual("5", service.PerformOperation("20", "15", '-'));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual("25", service.PerformOperation("5", "5", '*'));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual("3", service.PerformOperation("15", "5", '/'));
        }

        [Test]
        public void TestModulo()
        {
            Assert.AreEqual("3", service.PerformOperation("20", "17", '%'));
        }

        [Test]
        public void TestDivisionByZeroMessage()
        {
            Assert.AreEqual("Cannot divide by zero", service.PerformOperation("1", "0", '/'));
            Assert.AreEqual("Cannot divide by zero", service.PerformOperation("1", "", '/'));
            Assert.AreEqual("Cannot divide by zero", service.PerformOperation("1", null, '/'));
        }

        [Test]
        public void TestModuloByZeroMessage()
        {
            Assert.AreEqual("Cannot mod by zero", service.PerformOperation("1", "0", '%'));
            Assert.AreEqual("Cannot mod by zero", service.PerformOperation("1", "", '%'));
            Assert.AreEqual("Cannot mod by zero", service.PerformOperation("1", null, '%'));
        }

        [Test]
        public void TestSpacesInOperands()
        {
            Assert.AreEqual("30", service.PerformOperation("     15", "15      ", '+'));
        }

        [Test]
        public void TestInvalidOperator()
        {
            char op = 'a';
            Assert.AreEqual(String.Format("Invalid operator: {0}", 'a'), service.PerformOperation("1", "1", op));
        }

        [Test]
        public void TestEmptyOperands()
        {
            Assert.AreEqual("0", service.PerformOperation("", "", '+'));
            Assert.AreEqual("0", service.PerformOperation(null, null, '+'));
        }

        [Test]
        public void TestInvalidOperand()
        {
            Assert.AreEqual(String.Format("Invalid operand"), service.PerformOperation("abc", "1", '+'));
        }

        [Test]
        public void TestOperandTooLarge()
        {
            Assert.AreEqual("Operand value(s) too large to fit inside decimal", service.PerformOperation("80000000000000000000000000000", "0", '+'));
        }

        [Test]
        public void TestResultTooLarge()
        {
            string largeOperand = "5555555555555555";
            Assert.AreEqual("Result value too large to display", service.PerformOperation(largeOperand, largeOperand, '*'));
        }

        [Test]
        public void TestOperandTooLargeForExponential()
        {
            Assert.AreEqual("Operand value(s) too large for exponential function to be carried out", service.PerformOperation("20", "5000", '^'));
        }
    }
}
