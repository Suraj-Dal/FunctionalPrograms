using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class EvenOdd
    {
        public void check()
        {
            Console.WriteLine("Enter no. to check whether it is even or odd: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("Number is Even.");
            else
                Console.WriteLine("Number is Odd.");
        }
    }
}
