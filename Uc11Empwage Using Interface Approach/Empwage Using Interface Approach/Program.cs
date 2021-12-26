using System;

namespace Empwage_Using_Interface_Approach
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
            empWageBuilderArray.addCompanyEmpWage("Samsung", 25, 5, 22);
            empWageBuilderArray.addCompanyEmpWage("Facebook", 30, 6, 25);
            empWageBuilderArray.computeEmpWage();
        }
    }
}
