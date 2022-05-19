using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Largest
    {
        public void large()
        {
            Console.WriteLine("Enter three no. to find largest: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("Largest no. is: " + a);
            else if (b > a && b > c)
                Console.WriteLine("Largest no. is: " + b);
            else if (c > a && c > b)
                Console.WriteLine("Largest no. is: " + c);
        }
    }
}
