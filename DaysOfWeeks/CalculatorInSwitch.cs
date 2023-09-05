using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeeks
{
    internal class CalculatorInSwitch
    {
        static void Main (string[]args)
        {
            Console.WriteLine("Enter Numbers:");
            int num = Convert.ToInt32(Console.ReadLine());
            int a, b, c;

            switch (num)
            {
                case 0:
                    Console.WriteLine("Enter number 1:");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter number 2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Addition {0}", c);
                    break;
                case 1:
                    Console.WriteLine("Enter number 1:");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter number 2:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Multiplication {0}", c);
                    break;



            }
        }
    }
}
