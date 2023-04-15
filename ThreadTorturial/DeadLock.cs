using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTorturial
{
    public class DeadLock
    {
        public object _obj1 { get; }
        public object _obj2 { get; }

        public DeadLock(object obj1,object obj2)
        {
            _obj1 = obj1;
            _obj2 = obj2;
        }

    
        public void DeadLock1() { 
        
            lock (_obj1)
            {

                Console.WriteLine("thread 1 get locked");
                Thread.Sleep(1000);
                lock (_obj2)
                {
                    Console.WriteLine("threa 2 got locked");
                }
            }
        }

        public void DeadLock2()
        {

            lock (_obj2)
            {

                Console.WriteLine("thread 2 get locked");
                Thread.Sleep(1000);
                lock (_obj1)
                {
                    Console.WriteLine("threa 1 got locked");
                }
            }
        }
    }
}
