using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevator
{
    class Controller
    {
        public MyElevator el = new MyElevator();
      
      

      public   ConcurrentBag<Request> RequestList;

        
        public Controller()
        {
            RequestList = new ConcurrentBag<Request>();
        }


        public void AddMyRequest(Request r)
        {
            RequestList.Add(r);
        }

        public async  void ProcessRequests()
        {
           
           
            foreach ( var request in RequestList)
            {
                if(request.from < request.to)
                {
                    await Task.Delay(3000);
                    el.moveup(request.from, request.to);
                }
                else
                {
                    await Task.Delay(3000);
                    el.movedown(request.from,request.to);
                }



            }
        }


        public static void longtask()
        {
            Thread.Sleep(3000);
        }



    }
}
