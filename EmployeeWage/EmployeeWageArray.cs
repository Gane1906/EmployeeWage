using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageArray
    {
        const int IS_FULL_TIME = 1, IS_PART_TIME = 2;
        int noOfCompanies=0;
        ComputeEmployee[] computeEmployeeArray;
        public EmployeeWageArray()
        {
            computeEmployeeArray = new ComputeEmployee[5];
        }
        public void addCompany(String company, int wagePerHr, int noOfDays, int maxHrs, int fullTimeHr, int partTimeHr)
        {
            computeEmployeeArray[this.noOfCompanies] = new ComputeEmployee(company, wagePerHr, noOfDays, maxHrs, fullTimeHr, partTimeHr);
            noOfCompanies++;
        }
        public int calculateWage(ComputeEmployee computeEmployee)
        {
            int totalHrs = 0;
            Random random = new Random();
            for (int day = 0; day < computeEmployee.noOfDays && totalHrs < computeEmployee.maxHrs; day++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        totalHrs += computeEmployee.fullTimeHr;
                        break;
                    case IS_PART_TIME:
                        totalHrs += computeEmployee.partTimeHr;
                        break;
                }
            }
            return computeEmployee.wagePerHr * totalHrs;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i < noOfCompanies; i++)
            {
                computeEmployeeArray[i].setTotalWage(this.calculateWage(this.computeEmployeeArray[i]));
                Console.WriteLine(this.computeEmployeeArray[i].toString());
            }
            
        }
    }
}
