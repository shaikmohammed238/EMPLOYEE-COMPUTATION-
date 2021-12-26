using System;
using System.Collections.Generic;
using System.Text;

namespace Empwage_Using_Interface_Approach
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWages;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWages)
        {
            this.totalEmpWages = totalEmpWages;
        }

        public string toString()
        {
            return "Total emp wages for a company is : " + this.company + " is : " + this.totalEmpWages;
        }
    }
}
