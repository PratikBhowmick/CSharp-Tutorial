using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? TicketOnSale = null;
            int AvailableTickets;

            if(TicketOnSale == null)
            {
                AvailableTickets = 0;
            }

            else
            {
                AvailableTickets = TicketOnSale.Value;
            }

            Console.WriteLine("Available tickets are {0}", AvailableTickets);   
        }
    }
}
