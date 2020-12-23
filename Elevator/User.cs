using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class User
    {
        public int fromfloor;
        public int tofloor;

        public Request request(int from , int to)
        {
            Console.WriteLine(" NEW REQUEST RECIEVED: FROM : "+from + " "+" TO : "+to );
            return new Request(from, to);
        }

    }
}
