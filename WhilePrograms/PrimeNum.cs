using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrograms
{
    internal class PrimeNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            bool isprime = true;

            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    isprime = false;

                }

            }
            if (isprime == true)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }
        }
    }
}
