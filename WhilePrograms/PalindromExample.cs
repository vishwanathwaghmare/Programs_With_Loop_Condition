using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrograms
{
    internal class PalindromExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int r, sum = 0, temp;
            temp = num;

            while (num > 0)
            {
                r = num % 10;
                sum=(sum*10) + r;
                num /= 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("number is palindrome");

            }
            else
            {
                Console.WriteLine("not Palindrome");
            }

        }
    }
}
