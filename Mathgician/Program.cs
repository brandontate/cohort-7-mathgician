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
            if("Integers" == desiredMaths)
            {
                //Do something here
                PrintIntegers();
            } 
            else if  ("Fibonacci" == desiredMaths)
            {
                PringFibonacci();
            }
            else if ("Primes" == desiredMaths)
            {
                PrintPrimes();
            }
            else
            {
                Console.WriteLine("Well... Actually I lied");
            }
            System.Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void PrintPrimes()
        {
            int i = 2;
            var NumbersToCheck = new List<int> { };
            while (true)
            {
                bool found = false;
                for (int y = i - 1; y > 1; y--)
                {
                    if (i % y == 0)
                    {
                        found = true;
                    }
                }
                foreach (int number in NumbersToCheck)
                {
                    int answer = (i / number) % 1;
                    if (answer != 0)
                    {
                        found = true;
                    }

                }
                if (found == false) 
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(25);
                    NumbersToCheck.Add(i);
                }
                i++;
            }
        }

        private static void PringFibonacci()
        {
            //1, 1, 3, 5, 8, 13
            int current = 1;
            int prev = 0;
            while(true)
            {
                Console.WriteLine(current);
                System.Threading.Thread.Sleep(75);
                int newValue = current + prev;
                prev = current;
                current = newValue;
            }

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
