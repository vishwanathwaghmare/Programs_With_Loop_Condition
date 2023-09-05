using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrograms
{
    internal class PrimeWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            bool isprime = true;
            int i = 2;

            while(i<=num)
            {
                if(num%i==0)
                {
                    isprime = false;
                }
               

            }
            if(isprime==true)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("number not prime");
            }
        }
    }
}
