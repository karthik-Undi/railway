using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
namespace railway
{
    class Program
    {
        enum src { chennai = 1, delhi = 2 }
        public static List<PassengerDetail> passengerDetailsList = new List<PassengerDetail>();

        public static Dictionary<string, int> ttypes = new Dictionary<string, int>()
        {
            {"AC", 1500 },
            { "First Class Sleeper", 1000 },
            { "Second Class Sleeper", 750 },
            { "Third Class Sleeper" ,500 }
        };
        
        public static int iter()
        {
            String source, destination, id, name, tickettype = "";
            DateTime dob = DateTime.Now;

            Console.WriteLine("Enter id");
            id = Console.ReadLine();

            Console.WriteLine("Please enter the Investor Date of Birth (DD/MM/YYYY) ");
            if (!(DateTime.TryParse(Console.ReadLine(), out dob)))
            {
                Console.WriteLine("You have entered an incorrect format.");
                return 0;
            }

            if (PassengerDetailVerification.DetailVerification(dob, id) == 0) return 0;


            Console.WriteLine("Enter name");
            name = Console.ReadLine();


            Console.WriteLine("Enter source\n1.chennai\n2.delhi");
            int tempsrc = Convert.ToInt32(Console.ReadLine());
            source = Convert.ToString((src)tempsrc);


            Console.WriteLine("Enter destination\n1.chennai\n2.delhi");
            int tempdes = Convert.ToInt32(Console.ReadLine());
            destination = Convert.ToString((src)tempdes);



            Console.WriteLine("Select ticket type");
            for (int i = 0; i < ttypes.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + "." + ttypes.ElementAt(i).Key + "\tprice: " + ttypes.ElementAt(i).Value);
            }
            int tickettypechoice = Convert.ToInt32(Console.ReadLine());
            switch (tickettypechoice)
            {
                case 1:
                    tickettype = "AC"; break;
                case 2:
                    tickettype = "First Class Sleeper"; break;
                case 3:
                    tickettype = "Secons Class Sleeper"; break;
                case 4:
                    tickettype = "Third Class Sleeper"; break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }

            passengerDetailsList.Add(new PassengerDetail(id, name, source, destination, tickettype, dob));
            int index = passengerDetailsList.FindIndex(pass => pass.passengerId == id);
            TicketCostCalculation.TicketCalculate(passengerDetailsList[index]);
            return 0;
        }

        static void Main(string[] args)
        {
            for(; ; )
            iter();


        }
    }
}
