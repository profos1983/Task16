using System;
using System.Collections.Generic;
using System.Text;
using Task16_1_UserTicketService.Classes;
using Task16_1_UserTicketService.Exceptions;

namespace Task16_1_UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPriceMustReturnExistingPrice()
        {
            var ticketServiceTest = new TicketService();
            Assert.That(ticketServiceTest.GetTicketPrice(1), Is.Not.EqualTo(null));
            //Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
            
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

    }
}
