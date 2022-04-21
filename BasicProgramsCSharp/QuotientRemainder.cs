using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class QuotientRemainder
    {
        public void QuotientRemainderFinder()
        {
            Console.WriteLine("Finding Quotient and Remainder of a number!");
            Console.WriteLine("Enter the value of Divident : ");
            int divident = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the value of Divisor : ");
            int divisor = Convert.ToInt16(Console.ReadLine());
            int quotient = divident / divisor;
            Double remainder = divident % divisor;
            Console.WriteLine("The Quotient found is "+quotient);
            Console.WriteLine("The remainder found is "+remainder);

        }
    }
}
