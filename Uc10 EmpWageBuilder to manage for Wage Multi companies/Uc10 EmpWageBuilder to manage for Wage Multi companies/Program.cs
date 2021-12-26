using System;

namespace Uc10_EmpWageBuilder_to_manage_for_Wage_Multi_companies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welome to Employee Wage Program***********");
            Console.WriteLine("=====================================================================================================");

            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilderArray.addCompanyEmpWage("PhonePay", 15, 5, 22);
            empWageBuilderArray.computeEmpWage();
        }
    }
}
