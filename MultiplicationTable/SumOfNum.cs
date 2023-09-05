using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class SumOfNum
    {
        static void Main(string[] args)
        {
            int sum = 0, i;
            Console.WriteLine("The Number ");
            for(i=1;i<11;i++)
            {
                sum = sum + i;
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine(" the sum is {0}",sum);


        }
       
    }
}
