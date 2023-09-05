using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeeks
{
    internal class OddEvenSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num%2)
            {
                case 0:
                    Console.WriteLine(num + " Is even number");
                    break;
                case 1:
                    Console.WriteLine(num + " Is Odd Number");
                    break;
                
                    
            }
        }
    }
}
