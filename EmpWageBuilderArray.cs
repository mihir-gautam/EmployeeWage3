using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmpWageBuilderArray : IComputeEmpWage 
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public int numOfCompany = 0;
        public ArrayList companyEmpWageList = new ArrayList();

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage CEW = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWageList.Insert(numOfCompany, CEW);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                CompanyEmpWage comObj = (CompanyEmpWage)companyEmpWageList[i];
                comObj.setTotalEmpWage(this.EmpWageCompute(comObj));
                Console.WriteLine(comObj.toString());
            }
        }
        public int EmpWageCompute(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int checkShift = random.Next(0, 3);
                switch (checkShift)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs : " + totalEmpHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}
