using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class ComputeEmployee
    {
        const  int IS_FULL_TIME = 1, IS_PART_TIME = 2;
        private String company;
        private int wagePerHr;
        private int noOfDays;
        private int maxHrs;
        private int fullTimeHr;
        private int partTimeHr;
        private int totalWage;
        public ComputeEmployee(String company,int wagePerHr, int noOfDays, int maxHrs,int fullTimeHr,int partTimeHr)
        {
            this.company = company;
            this.wagePerHr = wagePerHr;
            this.noOfDays = noOfDays;
            this.maxHrs = maxHrs;
            this.fullTimeHr = fullTimeHr;
            this.partTimeHr = partTimeHr;
        }
        public  void calculateWage()
        {
            int wage = 0, totalHrs = 0;
            Random random = new Random();
            for (int day = 0; day < this.noOfDays && totalHrs < this.maxHrs; day++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        totalHrs += this.fullTimeHr;
                        break;
                    case IS_PART_TIME:
                        totalHrs += this.partTimeHr;
                        break;
                }
            }
            totalWage = this.wagePerHr * totalHrs;
            Console.WriteLine("Monthly wage of an employee in " + company + " is " + totalWage);
        }
        public string toString()
        {
            return "monthly wage of an employee in " + this.company + " is " + this.totalWage;
        }
    }
}
