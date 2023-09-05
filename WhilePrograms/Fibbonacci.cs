using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrograms
{
    internal class Fibbonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            int f1 = 0, f2 = 1, f3 = 0;
            int i = 2;
            while(i<=num)
            {
                f3= f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3 ;
                i++;
            }

        }
        
    }
}
