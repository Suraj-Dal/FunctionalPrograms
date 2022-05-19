using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Swap
    {
        public void change()
        {
            Console.WriteLine("Enter first no.: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no.: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping A: " + a + " B is: " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping A is: "+ a +" B is: "+ b);
        }
    }
}
