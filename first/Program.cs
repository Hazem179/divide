using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double r;
            Console.WriteLine("enter the first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            y= int.Parse(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("can't divide by zero");
            }
            else
            {
                r = x / y;
                Console.WriteLine("the result = "+r);
            }


        }
    }
}
