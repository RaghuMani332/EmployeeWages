using System;

namespace Exceptions
{
    public class Task
    {
        private static int wagePerHour = 20;
        private static int fullDayHour = 8;
        private static int partTimeDayHour = 8;

        public void Uc1()
        {
            int monthlyWage = CalculateWagesOfMonth();
            Console.WriteLine($"The monthly wage of the employee is: ${monthlyWage}");
        }

        public int EmployeeAttendance()
        {
            Random random = new Random();
            return random.Next(0, 2); // Generate a random number between 0 and 2
        }

        public int DailyEmployeeHours(int attendanceStatus)
        {
            if (attendanceStatus == 1)
            {
                return fullDayHour;
            }
           
            else
            {
                return 0;
            }
        }

        public int CalculateWagesOfMonth()
        {
            int numberOfWorkingDays = 20;
            int totalHours = 0;
            int monthlyWage = 0;

            for (int i = 0; i < numberOfWorkingDays; i++)
            {
                int hours = DailyEmployeeHours(EmployeeAttendance());
                if (totalHours + hours > 100)
                {
                    hours = 100 - totalHours; // Limit hours to 100 if it exceeds
                }
                totalHours += hours;
                monthlyWage += hours * wagePerHour;
            }

            return monthlyWage;
        }
    }
}
