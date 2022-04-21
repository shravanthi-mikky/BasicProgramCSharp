// See https://aka.ms/new-console-template for more information
using BasicProgramsCSharp;

Console.WriteLine("Do you want to Run the program?");
bool status = Convert.ToBoolean(Console.ReadLine());
while (status)
{
    Console.WriteLine("Choose the Program to be executed :\n1)Flip Coin\n2)Hello Message");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Welcome to Flip Coin Simulator!");
            FLipcoin flipCoin = new();
            flipCoin.FlipCoin();
            break;
        case 2:
            Console.WriteLine("Wemcome to Leap Year Problem!");
            LeapYear leapYear = new();
            leapYear.LeapYearFunction();
            break;
        default:
            break;
    }
}
