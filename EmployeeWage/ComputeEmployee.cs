using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public String company;
        public int wagePerHr;
        public int noOfDays;
        public int maxHrs;
        public int fullTimeHr;
        public int partTimeHr;
        public int totalWage;
        public ComputeEmployee(String company,int wagePerHr, int noOfDays, int maxHrs,int fullTimeHr,int partTimeHr)
        {
            this.company = company;
            this.wagePerHr = wagePerHr;
            this.noOfDays = noOfDays;
            this.maxHrs = maxHrs;
            this.fullTimeHr = fullTimeHr;
            this.partTimeHr = partTimeHr;
        }
        public void setTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
        
        public string toString()
        {
            return "monthly wage of an employee in " + this.company + " is " + this.totalWage;
        }
    }
}
