using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("D'Mart", 20, 6, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}