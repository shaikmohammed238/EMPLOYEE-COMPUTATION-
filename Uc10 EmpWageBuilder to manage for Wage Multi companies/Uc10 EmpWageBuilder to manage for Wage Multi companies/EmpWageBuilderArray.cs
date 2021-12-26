using System;
using System.Collections.Generic;
using System.Text;

namespace Uc10_EmpWageBuilder_to_manage_for_Wage_Multi_companies
{ 
    /// <summary>
  /// Declaration of constants
  /// And Array to store company emp wage
  /// </summary>
    class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;
        private CompanyempWage[] companyEmpWageArray;

        /// <summary>
        /// this method will store each compnies emp wage in array[] with index numbers starting from zero.
        /// </summary>
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyempWage[5];
        }

        /// <summary>
        /// Passing arguments in this method for multiple companies which is stored in array.
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyempWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        /// <summary>
        /// Compute employee wage for all companies
        /// </summary>
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        /// <summary>
        /// Calculate employee wage 
        /// </summary>
        /// <param name="companyEmpWage"></param>
        /// <returns></returns>
        public int computeEmpWage(CompanyempWage companyEmpWage)
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
    }
}
