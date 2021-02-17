using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace railway
{
    class TicketCostCalculation
    {
        public static void TicketCalculate(PassengerDetail p)
        {
            int age = 0;
            age = DateTime.Now.Year - p.dateOfBirth.Year;

            if (DateTime.Now.DayOfYear < p.dateOfBirth.DayOfYear)
                age = age-1;

            String Ticketcategory = p.ticketcategory;
            int Ticketprice = Program.ttypes[Ticketcategory];
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Passenger Name : "+p.name+"\nPassenger Age :" + age);
            if (age <= 10)
            {
                Ticketprice = 0;
                Console.WriteLine("Passenger Class : child\nTicket Category: "+Ticketcategory+"\nTicket Price : "+Ticketprice+"\ndiscount : 100%");
            }
            else if (age > 10 && age < 60)
            {
                //Ticketprice = 0;
                Console.WriteLine("Passenger Class : General\nTicket Category: " + Ticketcategory + "\nTicket Price : " + Ticketprice + "\ndiscount : None");
            }
            else if (age > 60)
            {
                Ticketprice = Ticketprice/2;
                Console.WriteLine("Passenger Class : Senior Citizen\nTicket Category: " + Ticketcategory + "\nTicket Price : " + Ticketprice + "\ndiscount : 50%");
            }
            Console.WriteLine("-------------------------------\n");
        }
    }
}
