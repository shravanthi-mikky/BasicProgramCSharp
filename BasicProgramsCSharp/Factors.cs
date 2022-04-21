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

            for (int i = 2; i < M; i++)
            {
                if(i%2 != 0)
                {
                    if(M%i == 0)
                    {
                        Console.WriteLine("{0} is prime factor of {1} ", i, M);
                    }
                }
            }
            
        }
    }
}
