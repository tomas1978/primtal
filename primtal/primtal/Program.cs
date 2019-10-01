using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primtal
{
    class Program
    {
        public static bool IsPrime(int tal)
        {
            if (tal < 2)
                return false;
            bool isPrime = true;
            for(int i=2;i<=Math.Sqrt(tal);i++)
            {
                if(tal%i==0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }

        public static void listPrimes(int lower, int upper)
        {
            for(int i=lower;i<=upper;i++)
            {
                if(IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter lower limit: ");
            int lowerLimit=int.Parse(Console.ReadLine());
            Console.Write("Enter upper limit: ");
            int upperLimit=int.Parse(Console.ReadLine());
            Console.WriteLine("All primes in interval " + lowerLimit + " to " + upperLimit);
            listPrimes(lowerLimit, upperLimit);
        }
    }
}
