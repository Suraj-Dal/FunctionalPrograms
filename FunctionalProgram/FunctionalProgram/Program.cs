﻿Console.WriteLine("1.Flip Coin\n2.Leap Year\n3.Power of Two\n4.Harmonic Number\n5.Prime Factor\n6.Dividatio\n7.Swapping\n8.Even Odd\n9.Vowel Consonant\n");
Console.WriteLine("Enter Your Choice:");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        FunctionalProgram.Function function = new FunctionalProgram.Function();
        function.flipCoin();
        break;
    case 2:
        FunctionalProgram.LeapYear year = new FunctionalProgram.LeapYear();
        year.Year();
        break;
    case 3:
        FunctionalProgram.Power power = new FunctionalProgram.Power();
        power.powerOfTwo();
        break;
    case 4:
        FunctionalProgram.Harmonic harmonic = new FunctionalProgram.Harmonic();
        harmonic.compute();
        break;
    case 5:
        FunctionalProgram.PrimeFactor prime = new FunctionalProgram.PrimeFactor();
        prime.factor();
        break;
    case 6:
        FunctionalProgram.ReminderQuotient cal = new FunctionalProgram.ReminderQuotient();
        cal.calculate();
        break;
    case 7:
        FunctionalProgram.Swap swap = new FunctionalProgram.Swap();
        swap.change();
        break;
    case 8:
        FunctionalProgram.EvenOdd eo = new FunctionalProgram.EvenOdd();
        eo.check();
        break;
    case 9:
        FunctionalProgram.Alphabet alphabet = new FunctionalProgram.Alphabet();
        alphabet.Vowel();
        break;
}
