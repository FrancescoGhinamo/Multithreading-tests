using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest.Async
{
    public class AsyncBreakfast
    {

        public async Task<string> PourCoffee()
        {
            Coffe c = new Coffe();
            return await c.PourCoffe();
        }

        public async Task MakeToast()
        {
            Toast t = new Toast();
            await t.ToastBread();
        }

        
        static async Task Main(string[] args)
        {
            AsyncBreakfast br = new AsyncBreakfast();
            Console.WriteLine("Starting to make breakfast");
            var coffee = br.PourCoffee();
            
            Console.WriteLine("Proceeding with toast");

            var toast = br.MakeToast();

            Console.WriteLine("Waiting for work to complete...");

            await Task.WhenAll(coffee, toast);


            Console.WriteLine("Breakfast's ready");
            Console.WriteLine("Coffee type: " + coffee.Result);
            Console.ReadKey();
            
            
        }
    }
}
