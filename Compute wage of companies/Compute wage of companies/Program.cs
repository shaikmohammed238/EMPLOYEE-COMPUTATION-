using System;

namespace Compute_wage_of_companies
{
    class Program
    {
            public const int isPartTime = 1;
            public const int isFullTime = 2;

            public static int computeEmpWage(string company, int empRatePerHour,
                int numOfWorkingDays, int maxHoursPerMonth)
            {
                //Variables
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                //Computation
                while (totalEmpHrs < maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case isPartTime:
                            empHrs = 4;
                            break;
                        case isFullTime:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs: " + empHrs);
                }
                int totalEmpWage = totalEmpHrs * empRatePerHour;
                Console.WriteLine("Total Emp Hrs: " + totalEmpHrs);
                Console.WriteLine("Total Emp Wage: " + totalEmpWage);
                return totalEmpWage;
            }
            static void Main(string[] args)
            {
                computeEmpWage("DMart", 20, 2, 10);
                computeEmpWage("Reliance", 10, 4, 20);
            }
        }
    }
