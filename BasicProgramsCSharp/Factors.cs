using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class Factors
    {
        public void PrimeFactors()
        {
            Console.WriteLine("Prime factors of M");
            Console.WriteLine("Enter the value of M : ");
            int M = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Prime factors of the number are : ");
            for (int i = 2; M>1; i++)
            {
                while (M % i == 0)
                {
                    M /= i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
