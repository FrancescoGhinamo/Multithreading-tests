using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest.Async
{
    public class AsyncProgram
    {

        public static string PourCoffee()
        {
            Thread.Sleep(500);
            return "Coffee poured";
        }

        public static string FryEggs(int n)
        {
            Thread.Sleep(1200);
            return "Friend " + n + " eggs";
        }

        public static string FryBacon(int n)
        {
            Thread.Sleep(700);
            return "Friend " + n + " slices of bacon";
        }

        public static string ToastBread(int n)
        {
            Thread.Sleep(2000);
            return "Toasted " + n + " slices of breadd";
        }

        static async Task Main(string[] args)
        {
            string coffee = PourCoffee();
            Console.WriteLine(coffee);
            string eggs = FryEggs(3);
            Console.WriteLine(eggs);
            string bacon = FryBacon(2);
            Console.WriteLine(bacon);
            string toast = ToastBread(1);
            Console.WriteLine(toast);

            Console.WriteLine("Breakfast ready");
            Console.ReadKey();
        }
    }
}
