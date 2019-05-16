using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest.Async
{
    public class Coffe
    {
        public async Task<string> PourCoffe()
        {
            
            return await Task.Run(() =>
            {
                Console.WriteLine("\t\tPouring coffee");
                Thread.Sleep(5000);
                Console.WriteLine("\t\tCoffee poured");
                return "Tim Horton\'s";
            });
        }
    }
}
