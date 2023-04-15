using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTorturial
{
    public class MatchBetweenThreads
    {
        public void Calculation(string str) { 
        for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(new Random().Next(5));
                Console.Write(str+" : "+i + "  ");
                Console.WriteLine();
            }
        Console.WriteLine("Finsh Calculate in Thread : "+str);
        }

        public void CreateThreadAndCallThem() {

            Thread[] tr=new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                int x = 0;
                x = i;
                tr[i] = new Thread(new ThreadStart(()=>Calculation("threadName("+x.ToString()+")")));
                tr[i].Name = "working thread : " + i;
            }

            foreach (Thread item in tr)
            {
                item.Start();
            }
            Console.ReadKey();
        }
    }

}
