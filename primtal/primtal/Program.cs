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
            bool isPrime = true;
            for(int i=2;i<Math.Sqrt(tal)+1;i++)
            {
                if(tal%i==0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
        static void Main(string[] args)
        {
            int tal = 23;
            Console.WriteLine(tal + " " + IsPrime(tal));
        }
    }
}
