namespace Task16_1_UserTicketService
{
    using NUnit.Framework;
    using Task16_1_UserTicketService.Classes;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(100 == 100, Is.True);
        }

        // Тест для задачи 16.2.4
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            
            Assert.That(32 == calc.Subtraction(40, 8), Is.True);
        }

        // Тест для задачи 16.2.5
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(3 == calc.Division(9,3), Is.True);
        }

        // Тест для задачи 16.2.6
        [Test]
        public void Division_Must_Return_DivideByZeroException()
        {
            Calculator calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(7, 0));
        }
    }
}
