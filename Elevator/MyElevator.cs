using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class MyElevator
    {

        public bool idle;

        public int curfloor;

        public int maxcapacity;

        public void moveup(int from, int to)
        {
            Console.WriteLine(" Elevater started ");
            while(from!= to)
                {
                //await Task.Delay(20000);
                Console.WriteLine(" floor no : " + from);
                from++;
            }

            Console.WriteLine(" Elevater Reached "+to);


        }

        public void movedown(int from,int to)
        {
            Console.WriteLine(" Elevater started ");
            while (from != to)
            {
             //   await Task.Delay(20000);
                Console.WriteLine(" floor no : " + from);
                from--;
            }

            Console.WriteLine(" Elevater Reached " + to);


        }


    }
}
