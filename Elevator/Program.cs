using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller();

            User user1 = new User();

           Request r1 = user1.request(1, 6);

            c.AddMyRequest(r1);

            c.ProcessRequests();

            Request r2 = user1.request(5, 1);

            c.AddMyRequest(r2);

            Console.ReadLine();



        }
    }
}
