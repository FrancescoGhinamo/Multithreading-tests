using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading1.Multithreading
{
    public class MultithreadProgram
    {

        
        static void Main(string[] args)
        {

            Thread th = Thread.CurrentThread;
            Console.WriteLine(th.ToString());

            ThreadStart wrightReference = new ThreadStart(WritingThread.WritingThreadRun);
            Thread wrightThread = new Thread(wrightReference);

            wrightThread.Start();

            ThreadStart beep1Reference = new ThreadStart(BeepThread1.Beep1);
            Thread beep1Thread = new Thread(beep1Reference);

            beep1Thread.Start();

            ThreadStart beep2Reference = new ThreadStart(BeepThread2.Beep2);
            Thread beep2Thread = new Thread(beep2Reference);

            beep2Thread.Start();



            Console.ReadKey();
            
        }
    }
}
