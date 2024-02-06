using System;

namespace Exceptions
{
    public class Task
    {
        private static int wagePerHour = 20;
        private static int fullDayHour = 8;
        private static int partTimeDayHour = 4;

        public void Uc1()
        {
            int monthlyWage = CalculateWagesOfMonth();
            Console.WriteLine($"The monthly wage of the employee is: ${monthlyWage}");
        }

        public int EmployeeAttendance()
        {
            Random random = new Random();
            return random.Next(0, 3); // Generate a random number between 0 and 2
        }

        public int DailyEmployeeWage(int attendanceStatus)
        {
            if (attendanceStatus == 1)
            {
                return wagePerHour * fullDayHour;
            }
            else if (attendanceStatus == 2)
            {
                return wagePerHour * partTimeDayHour;
            }
            else
            {
                return 0;
            }
        }


        public void PartTime()
        {

            int partTimeWagePerHour = 20;
            int partTimeDayHour = 8;

            int partTimeDailyWage = partTimeWagePerHour * partTimeDayHour;
            Console.WriteLine($"The daily wage for a part-time employee is: {partTimeDailyWage}");

        }

        public int CalculateWagesOfMonth()
        {
            int numberOfWorkingDays = 20;
            int monthlyWage = 0;

            for (int i = 0; i < numberOfWorkingDays; i++)
            {
                int dailyWage = DailyEmployeeWage(EmployeeAttendance());
                monthlyWage += dailyWage;
            }

            return monthlyWage;
        }
    }

}
