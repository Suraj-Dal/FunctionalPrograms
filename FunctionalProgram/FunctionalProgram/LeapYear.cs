using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter Year: ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if ((Year % 4 == 0) && (Year % 100 != 0))
            {
                Console.WriteLine(Year + " is a Leap Year.");
            }
            else if (Year % 400 == 0)
            {
                Console.WriteLine(Year + " is a Leap Year.");

            }
            else
            {
                Console.WriteLine(Year + " is not a Leap Year.");
            }
        }
    }
}
