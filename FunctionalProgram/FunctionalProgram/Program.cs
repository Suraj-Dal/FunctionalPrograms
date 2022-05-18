Console.WriteLine("1.Flip Coin\n2.Leap Year\n");
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
}
