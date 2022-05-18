using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Function
    {
        public void flipCoin()
        {
            int head = 0;
            int tail = 0;
            Random random = new Random();
            Console.WriteLine("How many times you want to toss the coin:");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int flip = random.Next(0, 2);
                if (flip == 1)
                {
                    head++;
                }
                else
                {
                    tail++;
                }

            }

            int headPer = head * 100 / count;
            int tailPer = tail * 100 / count;
            Console.WriteLine("Percentage of Heads is:" + headPer + "%");
            Console.WriteLine("Percentage of Tails is:" + tailPer + "%");
        }

    }
}
