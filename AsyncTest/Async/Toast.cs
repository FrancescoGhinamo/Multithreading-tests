using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest.Async
{
    public class Toast
    {
        public async Task ToastBread()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("\t\t\t\tToasting bread");
                Thread.Sleep(10000);
                Console.WriteLine("\t\t\t\tToast ready");
            });

        }
    }
}
