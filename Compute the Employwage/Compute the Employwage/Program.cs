using System;

namespace Compute_the_Employwage
{
    class Program
    {
            public const int isFullTime = 2;
            public const int isPartTime = 1;
            public const int empRatePerHour = 20;
            public const int numOfWorkingDays = 20;
            public const int maxHrsInMonth = 100;

            public static int computeEmpWage()
            {
                //Variables
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                //Computation
                while (totalEmpHrs < maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
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
                Console.WriteLine("Welcome to Employee Wage Problem: ");
                computeEmpWage();
            }
        }
    }
