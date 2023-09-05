using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeeks
{
    internal class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int num1 = 2;
            int expo = 3;
            int power = 1;

            for (int i = 0; i <= expo; i++) ;
            {
                power = power * num;
            }
            Console.WriteLine(power);

        }
    }
}
//not correct