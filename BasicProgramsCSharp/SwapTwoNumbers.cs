using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Swapping two numbers!");
            Console.WriteLine("Enter the value of first : ");
            int first = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the value of second : ");
            int second = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("before swapping : {0} , {1} ", first, second);

            int temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After swapping : {0} , {1} ",first,second);
        }
    }
}
