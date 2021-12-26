using System;
using System.Collections.Generic;
using System.Text;

namespace UC14totalwagequriedwithcompany
{
    /// <summary>
    /// Declaration of constants
    /// And Array to store company emp wage
    /// </summary>
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        //Store emp wage along with total wage
        LinkedList<CompanyEmpWage> companyEmpWageList;
        Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        /// <summary>
        /// Passing parameter in addCompanyEmpWage
        /// like company name,rate per hr, working days etc.
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        /// <summary>
        /// Calculating emp wage for each company
        /// </summary>
        /// <param name="companyEmpWage"></param>
        /// <returns></returns>
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmployeeHour = 0;
            while (totalEmployeeHour <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                totalEmployeeHour += empHrs;
                Console.WriteLine("Day=" + totalWorkingDays + " Emplyee hours=" + empHrs);
            }
            return totalEmployeeHour * companyEmpWage.empRatePerHour;
        }
        /// <summary>
        /// Storing totalempwage for each company into dictionary
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWages;
        }
    }
}
