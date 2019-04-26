using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading1.Multithreading
{
    public class BeepThread1
    {
        public static void Beep1()
        {
            
            while(true)
            {
                Console.Beep(5000, 300);
                Thread.Sleep(700);
            }
        }
    }
}
