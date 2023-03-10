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
        const int IS_PRESENT = 1, WAGE_PER_HR = 20, NO_OF_HRS = 8;
        public void attandance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else 
                Console.WriteLine("Employee is absent");
        }
        public void wagePerDay()
        {
            int wage = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                wage = WAGE_PER_HR * NO_OF_HRS;
            Console.WriteLine("Daily wage of an employee is: "+wage);
        }
    }
}
