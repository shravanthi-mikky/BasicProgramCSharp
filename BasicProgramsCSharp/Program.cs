// See https://aka.ms/new-console-template for more information
using BasicProgramsCSharp;

Console.WriteLine("Do you want to Run the program?");
bool status = Convert.ToBoolean(Console.ReadLine());
while (status)
{
    Console.WriteLine("Choose the Program to be executed :\n1)Flip Coin\n2) leap year\n3) Power of 2\n4) Prime Factors\n5) Finding Quotient and remainder\n6) Swapping numbers\n7 Vowel or consonent\n8) Even odd\n9) Biggest of three numbers.");
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
        case 3:
            Console.WriteLine("Power of two!");
            PowerOf2  powers = new();
            powers.PowerOfTwo();
            break;
        case 4:
            Console.WriteLine("Prime factors!");
            Factors prime = new();
            prime.PrimeFactors();
            break;
        case 5:
            Console.WriteLine("Finding Quotient and remainder!");
            QuotientRemainder qr = new();
            qr.QuotientRemainderFinder();
            break;
        case 6:
            Console.WriteLine("Swapping the numvers!");
            SwapTwoNumbers swap = new();
            swap.Swap();
            break;
        case 7:
            VowelConsonent vc = new();
            vc.Vowel();
            break;
        case 8:
            EvenOdd eo = new();
            eo.EvenOddMethod();
            break;
        case 9:
            BiggestOfThree biggestOfThree = new();
            biggestOfThree.MaxOfThree();
            break;
        default:
            break;
    }
}
