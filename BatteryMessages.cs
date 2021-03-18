using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
   public static class BatteryMessages
    {
        public static void DisplayBatteryStatus(string property, BatteryStates batteryLevel)
        {
           
            Console.WriteLine($"Battery {property} is {batteryLevel}");
        }

        public static void DisplayWarningMessage(string warning,IReporter reporter)
        {
            Console.WriteLine($"Console Output:{warning}");
            reporter = new TextReporter();
            reporter.ReportData(warning);
            reporter = new UIReporter();
            reporter.ReportData(warning);
        }
    }
}
