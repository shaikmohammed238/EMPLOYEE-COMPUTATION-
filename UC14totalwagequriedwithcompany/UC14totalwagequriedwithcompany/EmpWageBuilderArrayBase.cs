namespace UC14totalwagequriedwithcompany
{
    public class EmpWageBuilderArrayBase
    {

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
    }
}