using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class LeapYear
    {
        public void LeapYearFunction()
        {
            Console.WriteLine("Welcome to Leap Year Computation!");
            Console.WriteLine("Enter the Year : x");
            int year = Convert.ToInt16(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                Console.WriteLine("{0} is a Leap Year ", year);
            else
                Console.WriteLine("{0} is not a Leap Year ", year);
        }
    }
}
