using System;
using System.Collections.Generic;
using System.Text;

namespace UC14totalwagequriedwithcompany
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWages;

        /// <summary>
        /// Parameterised Constructor initialized
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        /// <summary>
        /// Passing totalempwage into setTotalempwage method
        /// </summary>
        /// <param name="totalEmpWages"></param>
        public void setTotalEmpWage(int totalEmpWages)
        {
            this.totalEmpWages = totalEmpWages;
        }

        /// <summary>
        /// ToString () Method is used to read object into striing format
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            return "Total emp wages for a company is : " + this.company + " is : " + this.totalEmpWages;
        }
    }
}
