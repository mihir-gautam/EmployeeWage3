using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(String[] args)
        {
        ForMultipleCompanies.ComputeEmpWage("Microsoft", 20, 2, 10);
        ForMultipleCompanies.ComputeEmpWage("Apple", 10, 4, 20);
        }
    }
}