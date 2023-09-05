using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrograms
{
    internal class CompoundIntrest
    {
        static void Main(string[] args)
        {
            double ci, amount, p, r;
            int n, t, i;

            Console.WriteLine("Enter Principal balance=");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of intrest=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Compound Frequency=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Time period=");
            t= Convert.ToInt32(Console.ReadLine());

            amount = p;

            for(i=0;i<n*t; i++)
            {
                amount = amount + amount * (r / (n * 100));
                ci = amount - p;
                Console.WriteLine("compound intrest")
            }


        }
    }
}
