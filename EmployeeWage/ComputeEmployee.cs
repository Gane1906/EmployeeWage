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
        const  int IS_PRESENT = 1, IS_FULL_TIME = 1, IS_PART_TIME = 2;
        public static void attandance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else 
                Console.WriteLine("Employee is absent");
        }
        public static void calculateWage(int wagePerHr,int fullTimeHr,int partTimeHrs,int noOfDays,int maxHrs)
        {
            int wage = 0, totalHrs = 0;
            Random random = new Random();
            for(int day = 0; day < noOfDays && totalHrs<maxHrs; day++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        totalHrs += fullTimeHr;
                        break;
                    case IS_PART_TIME:
                        totalHrs += partTimeHrs;
                        break;
                }
            }
            wage = wagePerHr * totalHrs;
            Console.WriteLine("Monthly wage of an employee is: "+wage);
        }
    }
}
