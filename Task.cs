using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Task
    {
        public void uc1()
         {
        Random random = new Random();
        int attendance = random.Next(0, 2); // Generate a random number between 0 and 1

        if (attendance == 1)
        {
            Console.WriteLine("Employee is present");
        }
        else if (attendance == 0)
        {
            Console.WriteLine("Employee is absent");
        }
    }
    }
}
