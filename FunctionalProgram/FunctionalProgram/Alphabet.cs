using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Alphabet
    {
        public void Vowel()
        {
            Console.WriteLine("Enter any Alphabet to chveck whwther it is Vowel or Consonant: ");
            char a = Convert.ToChar(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                Console.WriteLine("Alphabet is Vowel.");
            else
                Console.WriteLine("Alphabet is consonant.");
        }
    }
}
