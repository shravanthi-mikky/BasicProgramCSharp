using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsCSharp
{
    public class VowelConsonent
    {
        public void Vowel()
        {
            Console.WriteLine("Finding Vowel or Consonent!");

            Console.WriteLine("Please Enter an Alphabet (A-Z or a-z).  alphabet : ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            if (alphabet == 'A' || alphabet == 'a')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (alphabet == 'E' || alphabet == 'e')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (alphabet == 'I' || alphabet == 'i')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (alphabet == 'I' || alphabet == 'i')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (alphabet == 'U' || alphabet == 'u')
                Console.WriteLine("Entered Alphabet is Vowel");
            else
                Console.WriteLine("Entered Alphabet is a Consonent");
        }
    }
}
