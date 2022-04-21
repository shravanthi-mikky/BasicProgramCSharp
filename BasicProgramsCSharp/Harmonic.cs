using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class Harmonic
    {
        public void HarmonicSeries()
        {
            double H = 0;
            Console.WriteLine("Enter the values of n");
            double n = Convert.ToDouble(Console.ReadLine());
            for (double i = 1; i < (n + 1); i++)
            {
                H += 1 / i;
                Console.Write(" 1/{0}+ ",i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("The nth Harmonic of n is :"+H);
        }
    }
}
