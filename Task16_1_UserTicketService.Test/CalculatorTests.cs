using System;
using System.Collections.Generic;
using System.Text;
using Task16_1_UserTicketService.Classes;

namespace Task16_1_UserTicketService
{
    [TestFixture]
    internal class CalculatorTests
    {
        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
    }
}
