using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class FullTime
    {

        public void EmployeFullTime()
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, 2);
            const int FullTime = 1;
            int empWagePerHr = 20;
            int empHr = 0;
            int totalWage = 0;

            if (RandomNumber == FullTime)
            {
                Console.WriteLine("Emplyee worked for full time");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Emplyee is absent");
            }

            totalWage = empWagePerHr * empHr;
            Console.WriteLine("Total wage of employye for full time is" + totalWage);

        }
    }
}
