using System;

namespace Exceptions
{
   public class Task
    {
        public void Uc1()
        {
            Random random = new Random();
            int attendance = random.Next(0, 2); // Generate a random number between 0 and 1

            if (attendance == 1)
            {
                Console.WriteLine("Employee is present");
                DailyEmployeeWage();
            }
            else if (attendance == 0)
            {
                Console.WriteLine("Employee is absent");
            }
        }

        public void DailyEmployeeWage()
        {
            int fullTimeWagePerHour = 20;
            int fullDayHour = 8;
            if (EmployeeAttendance() == 1)
            {
                int dailyWage = fullTimeWagePerHour * fullDayHour;
                Console.WriteLine($"The daily wage for a full-time employee is: {dailyWage}");
            }
            else
            {
                Console.WriteLine("The employee is not present");
            }

        }
        public void PartTime()
        {
           
            int partTimeWagePerHour = 20;
            int partTimeDayHour = 8;

                int partTimeDailyWage = partTimeWagePerHour * partTimeDayHour;
                Console.WriteLine($"The daily wage for a part-time employee is: {partTimeDailyWage}");
            
        }

        public int EmployeeAttendance()
        {
            Random random = new Random();
            return random.Next(0, 2); // Generate a random number between 0 and 1
        }
    }
}
