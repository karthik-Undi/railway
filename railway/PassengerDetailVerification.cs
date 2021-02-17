using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace railway
{
    class PassengerDetailVerification : PassengerDetail
    {

        public static int DetailVerification(DateTime dob, String ID)
        {
            int age = DateTime.Now.Year - dob.Year;
            Regex r = new Regex("[A-Z]{2}[0-9]{5}[A-Z]{1}");

            if (!(r.IsMatch(ID)))
            {
                Console.WriteLine("You have entered an incorrect ID format.\n\n");
                return 0;
            }
            else if (age <= 10)
            {

            }
            else if (age > 10 && age < 60)
            {
            }
            else if (age > 60)
            {
            }
            else
            {
                Console.WriteLine("age cant be negative");
                return 0;
            }
            return 1;
        }
    }
}
