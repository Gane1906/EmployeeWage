using System;
namespace EmployeeWage
{
    public class Program
    {
        static void Main(String[] args)
        {
            EmployeeWageArray employeeWageArray = new EmployeeWageArray();
            employeeWageArray.addCompany("tcs", 50, 25, 100, 8, 4);
            employeeWageArray.addCompany("wipro", 45, 20, 100, 6, 3);
            employeeWageArray.computeEmpWage();
        }
    } 
}