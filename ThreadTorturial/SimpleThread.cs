using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTorturial
{
    public class SimpleThread
    {

        public void Thread1Job()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("From thread1: " + counter);
            }
        }

        public void Thread2Job()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("From thread2: " + counter);
            }
        }

        public void Thread3Job()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("From thread3: " + counter);
            }
        }
    }
}
