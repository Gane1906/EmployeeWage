using System;
namespace EmployeeWage
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Employee monhtly wage for jio company");
            ComputeEmployee.calculateWage(50,6,3,28,100);
            Console.WriteLine("Employee monhtly wage for Xyz company");
            ComputeEmployee.calculateWage(40, 8, 4, 30, 100);
        }
    } 
}