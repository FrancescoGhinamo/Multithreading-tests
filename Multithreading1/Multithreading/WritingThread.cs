using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading1.Multithreading
{
    public class WritingThread
    {
        public static void WritingThreadRun()
        {
            while(true)
            {
                Console.WriteLine("Thread is running");
                Thread.Sleep(1000);
            }
        }
    }
}
