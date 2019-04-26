using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading1.Multithreading
{
    public class BeepThread2
    {
        public static void Beep2()
        {

            while (true)
            {
                Console.Beep(440, 500);
                Thread.Sleep(200);
            }
        }
    }
}
