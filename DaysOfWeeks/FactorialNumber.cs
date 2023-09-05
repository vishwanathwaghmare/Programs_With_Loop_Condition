using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeeks
{
    internal class FactorialNumber
    {
        static void Main(string[] args)
        {
            int i, fact = 1, num;
            Console.WriteLine("Enter a Number:");
            num=Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
                
            }
            Console.WriteLine("Factorial of given number is:" + fact);
        }
    }
}
