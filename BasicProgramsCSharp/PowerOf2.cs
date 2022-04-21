using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class PowerOf2
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("Power of Two");
            Console.WriteLine("Enter the value of N : ");
            int N = Convert.ToInt16(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                double num;
                num = Math.Pow(2, i);
                Console.WriteLine("2 to power of {0} is {1} ",i,num);
            }

        }
    }
}
