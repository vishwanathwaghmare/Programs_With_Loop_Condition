using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeeks
{
    internal class DivisibleBy3
    {
        static void Main(string[] args)
        {
            int num;
            for(int i = 0; i <= 30; i++)
            {
               if(i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
