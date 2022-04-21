using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class FLipcoin
    {
        public void FlipCoin()
        {
            Console.WriteLine("Welcome To Flip Coin Problem");
            int head = 0;
            int tail = 0;
            Console.WriteLine("Enter Number of times the coin should be Flipped : ");
            int numOfFlips = Convert.ToInt32(Console.ReadLine());
            double mid = 0.5;
            for (int i = 0; i < numOfFlips; i++)
            {
                Random test = new();
                double Flip = test.NextDouble();
                if (Flip > mid)
                {
                    head++;
                    Console.WriteLine("Heads!");
                }
                else
                {
                    tail++;
                    Console.WriteLine("Tails!");

                }
            }
            Console.WriteLine("Number of times we got heads : " + head);
            Console.WriteLine("Number of times we got tails : " + tail);
            int percentageOfHeads = ((head * 100) / numOfFlips);
            Console.WriteLine("The Percentage of Heads is : " + percentageOfHeads);
            int percentageOfTails = (100 - percentageOfHeads);
            Console.WriteLine("The Percentage of tails id : " + percentageOfTails);
        }
    }
}
