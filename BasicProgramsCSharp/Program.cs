// See https://aka.ms/new-console-template for more information
using BasicProgramsCSharp;

Console.WriteLine("Do you want to Run the program?");
bool status = Convert.ToBoolean(Console.ReadLine());
while (status)
{
    Console.WriteLine("Choose the Program to be executed :\n1)Flip Coin");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Welcome to Flip Coin Simulator!");
            FLipcoin flipCoin = new();
            flipCoin.FlipCoin();
            break;
        default:
            break;
    }
}
