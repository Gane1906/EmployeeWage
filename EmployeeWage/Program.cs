using System;
namespace EmployeeWage
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee problem");
            ComputeEmployee computeEmployee = new ComputeEmployee();
            computeEmployee.attandance();
            computeEmployee.calculateWage();
        }
    } 
}