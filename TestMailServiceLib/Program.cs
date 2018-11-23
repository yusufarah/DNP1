using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutEmailService;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MailService mail = new MailService("VIACINEMA2018@gmail.com");
            mail.sendBookingConfirmationTo("VIACINEMA2018@gmail.com",
                "DeadPool: another day to pool the dead",
                new DateTime(2018, 01, 01, 2, 15, 00),
                5,
                "15",
                10);

        }
    }
}
