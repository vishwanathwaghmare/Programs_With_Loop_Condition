using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project1
{
    internal class TableMulti
    {
        static void Main(string[] args)
        {
            //to check if...else statement......
            Console.WriteLine("Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=10;i++)
            {
                Console.WriteLine("{0} X{1} ={2}", num, i, num * i);
            }


      

        }
    }
}
