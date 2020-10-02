using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("D'Mart", 20, 6, 10);
            dmart.ComputeEmpWage("D'Mart", 20, 6, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            reliance.ComputeEmpWage("Reliance", 10, 4, 20);
        }
    }
}