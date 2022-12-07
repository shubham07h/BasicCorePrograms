using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {

        public void FindLeap()
        {
            Console.WriteLine("Enter a Year");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("It is a Leap Year");
            }

            else
            {
                Console.WriteLine("it is a not leap year");
            }
        }
    }
}
