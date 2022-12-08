using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class swap
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Input the First Number :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number :");
            b = int.Parse(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping :");
            Console.WriteLine("First Number : " + a);
            Console.WriteLine("Second Number : " + b);
            Console.Read();
        }
    }
}
    

