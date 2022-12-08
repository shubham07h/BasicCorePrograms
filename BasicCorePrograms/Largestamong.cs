

using System;
namespace BasicCorePrograms
{
     class Largestamong
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = 0;
            if (num1 > num2 && num1 > num3)
            {
                largest = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }
            Console.WriteLine("The largest number is {0}", largest);
        }
    }
}

