using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Harmonic
    {
        public void compute()
        {
            Console.WriteLine("Enter N to find Harmonic number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float harmonic = 1;

            if (n != 0)
            {
                for (float i = 2; i <= n; i++)
                {
                    harmonic = harmonic + (1 / i);
                }
                Console.WriteLine("Harmonic number is: " + harmonic);
            }
        }
    }
}
