using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage CEW = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(CEW);
            this.companyToEmpWageMap.Add(company, CEW);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.EmpWageCompute(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        public int EmpWageCompute(CompanyEmpWage companyEmployeeWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int empRatePerHour = 20;

            while (totalEmpHrs <= companyEmployeeWage.maxHoursPerMonth && totalWorkingDays < companyEmployeeWage.numOfWorkingDays)
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
                Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs : " + totalEmpHrs + " Daily Wage : " + empHrs * empRatePerHour);
            }
            return totalEmpHrs * companyEmployeeWage.empRatePerHour;
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}
