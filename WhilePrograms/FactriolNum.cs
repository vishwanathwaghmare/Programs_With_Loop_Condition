using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrograms
{
    internal class FactriolNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            int i = 1;
            while (num >= 1)
            {
                sum = sum * num;
                num--;
            }
            Console.WriteLine($"Factorial of the number" + sum);
        }
    }
}
