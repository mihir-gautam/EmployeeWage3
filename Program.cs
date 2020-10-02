using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("D'Mart", 20, 6, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for DMart company : " + empWageBuilder.getTotalWage("D'Mart"));
        }
    }
}