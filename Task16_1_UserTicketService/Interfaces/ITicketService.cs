using System;
using System.Collections.Generic;
using System.Text;

namespace Task16_1_UserTicketService.Interfaces
{
    public interface ITicketService
    {
        int GetTicketPrice(int ticketId);
    }
}
