using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class ReminderQuotient
    {
        public void calculate()
        {
            Console.WriteLine("Enter Dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            double quot = dividend / divisor;
            double rem = dividend % divisor;
            Console.WriteLine("Quotient is: " + quot);
            Console.WriteLine("Reminder is: "+ rem);
        }
    }
}
