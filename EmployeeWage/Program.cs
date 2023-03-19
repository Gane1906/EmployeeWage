using System;
namespace EmployeeWage
{
    public class Program
    {
        static void Main(String[] args)
        {
            ComputeEmployee tcs = new ComputeEmployee("tcs",50,25,100,8,4);
            tcs.calculateWage();
            ComputeEmployee wipro = new ComputeEmployee("Wipro",45,25,100,6,3);
            wipro.calculateWage();
        }
    } 
}