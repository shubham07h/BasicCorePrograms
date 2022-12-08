using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet: ");
            char ch = char.Parse(Console.ReadLine());
            switch (char.ToUpper(ch))
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("The alphabet is a vowel");
                    break;
                default:
                    Console.WriteLine("The alphabet is a consonant");
                    break;
            }
        }
    }
}
    


