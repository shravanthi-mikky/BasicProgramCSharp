using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class EvenOdd
    {
        public void EvenOddMethod()
        {
            Console.WriteLine("Enter the value : ");
            int Number = Convert.ToInt16(Console.ReadLine());
            if ((Number % 2) == 0)
            {
                Console.WriteLine("{0} is even!",Number);

            }
            else
            {
                Console.WriteLine("{0} is odd",Number);
            }
        }
    }
}
