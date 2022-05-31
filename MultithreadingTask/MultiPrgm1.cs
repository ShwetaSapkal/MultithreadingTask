using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultithreadingTask
{
    class MultiPrgm1
    {
        public void Run()
        {
            Thread t = Thread.CurrentThread;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(i);
                Thread.Sleep(500); // ms
            }
        }



    }
}
