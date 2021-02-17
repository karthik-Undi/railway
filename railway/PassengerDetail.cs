using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace railway
{
    class PassengerDetail
    {
        public String name, source, destination, ticketcategory, passengerId;
        public DateTime dateOfBirth;
        
        //String id1, String name1,String source1, String dest1, String ticketcat1, DateTime dob1
        public PassengerDetail()
        {

        }
        public PassengerDetail(string id1, string name1, string source1, string dest1, string tickettype1, DateTime dob)
        {
            this.passengerId = id1;
            this.name = name1;
            this.source = source1;
            this.destination = dest1;
            this.ticketcategory = tickettype1;
            this.dateOfBirth = dob;

        }
        public void disp()
        {
            Console.WriteLine(passengerId + "" + name + "" + ticketcategory);
        }
    }

}
