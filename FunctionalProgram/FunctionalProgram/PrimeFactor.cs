using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class PrimeFactor
    {
        public void factor()
        {
            Console.WriteLine("Enter the no. to find prime factors: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime factors of " + n + " are:");
            for (int i = 2; i < n; i++) {
                while (n % i == 0) {
                    Console.WriteLine(i + " ");
                    n = n / i;
                }
            }
            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }
    }

}
