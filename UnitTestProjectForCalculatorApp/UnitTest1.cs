using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
namespace UnitTestProjectForCalculatorApp
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator _calculator;
        private Book _book;
        

        [TestInitialize]
        public void InitializeTest()
        {
            // Arrange : set the object instance
            _calculator = new Calculator();
            _book = new Book("java" , 2012);

        }

        [TestMethod]
        public void TestSum()
        {
            // Act : call the method
            int actualValue = _calculator.Sum(1, 2);

            int k = _calculator.Sub(2, 2);
            // Assert : check expectancy of method
            Assert.AreEqual(3, actualValue);
        }

        [TestMethod]
        public void TestDiv()
        {
            // Act : call the method
            int actualValue = _calculator.Div(0, 8);

            // Assert : check expectancy of method
            Assert.AreEqual(0, actualValue);
        }

        [TestMethod]
        public void LegalTestMethod()
        {
            Assert.AreEqual("java" , _book.Title);
            Assert.AreEqual(2012 , _book.Year);
        }
        [TestMethod]
        public void IlLegalTestMethod()
        {
            // illegal values 
            _book.Title = "py";
            _book.Year = 2019;

            Assert.Fail("Business constraint does not allow us to use less than 2 character ");
            //Assert.AreNotEqual("py", _book.Title);
            //Assert.AreNotEqual(2019 , _book.Year);
        }
    }
}
