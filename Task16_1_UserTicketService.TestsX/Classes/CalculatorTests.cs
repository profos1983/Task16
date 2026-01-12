using System;
using System.Collections.Generic;
using System.Text;
using Task16_1_UserTicketService.Classes;

namespace Task16_1_UserTicketService.TestsX.Classes
{
    public class CalculatorTests
    {
        [Fact]
        public void Multiplication_Must_Return_NotNull_Value()
        {
            var calculator = new Calculator();


            Assert.Equal(45, calculator.Multiplication(5, 9));
        }

        // Тест по задаче 16.2.7
        [Fact]
        public void Subtraction_Must_Return_Correct_Value()
        {
            var calculator = new Calculator();
            Assert.Equal(5, calculator.Subtraction(6,1));
        }

        // Тест по задаче 16.2.8
        [Fact]
        public void Division_Must_Return_Correct_Value()
        {
            var calculator = new Calculator();
            Assert.Equal(3, calculator.Division(6, 2));
        }

        // Тест по задаче 16.2.9
        [Fact]
        public void Division_Must_Return_DivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(6, 0));
        }

        int a = ((int)DayOfWeek.Понедельник);
    }


    enum DayOfWeek
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

   
}
