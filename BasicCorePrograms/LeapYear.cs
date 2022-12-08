using System;

namespace Compute_Quotient_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient = {0}", quotient);
            Console.WriteLine("Remainder = {0}", remainder);
            Console.ReadLine();
        }
    }
}