using System;

namespace Uc9_EMPLOYWAGE_BUILDER_FOR_EACH_COMPANY
{
    class Program
    {
       static void Main(string[] args)
        {
            EMPLOY_WAGE_BUILD_PROJECT dMart = new EMPLOY_WAGE_BUILD_PROJECT("DMart", 20, 2, 10);
             EMPLOY_WAGE_BUILD_PROJECT reliance = new  EMPLOY_WAGE_BUILD_PROJECT("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
