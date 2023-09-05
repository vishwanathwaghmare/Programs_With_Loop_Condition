using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrograms
{
    internal class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            int  sum = 0, i;
            while(num>0)
            {
                i = num % 10;
                sum=sum+i;
                num = num / 10;

            }
            Console.WriteLine("sum is" + sum);
        }
    }
}
