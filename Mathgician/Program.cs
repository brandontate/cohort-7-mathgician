using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the Mathgician");
            Console.WriteLine("What shall I math?\nFibonacci, Primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok. I'm gonna do some " + desiredMaths);
            if( "Integers" == desiredMaths)
            {
                //Do something here
                PrintIntegers();
            }
            else
            {
                Console.WriteLine("Well... Actually I lied");
            }
            System.Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void PrintIntegers()
        {
            int NextInteger = 0;
            while(true)
            {
                NextInteger++;
                Console.WriteLine(NextInteger);
            }
        }
    }
}
