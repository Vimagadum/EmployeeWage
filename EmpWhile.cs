using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWhile
    {
        public void Employeeee()
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            int empHrs = 0;
            int totalHrs = 0;
            int empWagePrHr = 20;
            int EmpWage = 0;
            int total_Wage = 0;
            int WorkingHrs = 0;
            int Max_Working_Days = 20;
            int Max_Working_Hrs = 100;
            int days = 1;
            Random random = new Random();
            days = 1;
            while(days <= Max_Working_Days && WorkingHrs <= Max_Working_Hrs)
            {
                int RandomNumber = random.Next(0, 3);
                if (RandomNumber == Full_Time)
                {
                    Console.WriteLine("Emplyee worked for full time");
                    empHrs = 8;
                }
                else if (RandomNumber == Part_Time)
                {
                    Console.WriteLine("Emplyee worked for part time");
                    empHrs = 4;
                }
                else
                {
                    Console.WriteLine("Emplyee is absent");
                }
                
                EmpWage = empHrs * empWagePrHr;
                Console.WriteLine("EMployee wage for day {0} is {1}", days, EmpWage);
                total_Wage += EmpWage;
                totalHrs += empHrs;
                days++;

            }
            Console.WriteLine("totalHrs wage of employee for {0} days is {1} hours is {2}", Max_Working_Days, totalHrs, total_Wage);

        }
    }
}
