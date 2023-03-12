using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class ComputeEmployee
    {
        const  int IS_PRESENT = 1, WAGE_PER_HR = 20, NO_OF_HRS = 8, PART_TIME_HRS = 4, IS_FULL_TIME = 1, IS_PART_TIME = 2, NO_OF_DAYS = 20, MAX_HRS = 100;
        public static void attandance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else 
                Console.WriteLine("Employee is absent");
        }
        public static void calculateWage()
        {
            int wage = 0, totalHrs = 0;
            Random random = new Random();
            for(int day = 0; day < NO_OF_DAYS && totalHrs<MAX_HRS; day++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        totalHrs += NO_OF_HRS;
                        break;
                    case IS_PART_TIME:
                        totalHrs += (NO_OF_HRS / 2);
                        break;
                }
            }
            wage = WAGE_PER_HR * totalHrs;
            Console.WriteLine("Monthly wage of an employee is: "+wage);
        }
    }
}
