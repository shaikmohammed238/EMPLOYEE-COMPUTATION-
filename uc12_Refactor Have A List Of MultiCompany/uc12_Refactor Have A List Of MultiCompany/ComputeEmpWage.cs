using System;
using System.Collections.Generic;
using System.Text;

namespace Empwage_Using_Interface_Approach
{
    interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
    }
}
