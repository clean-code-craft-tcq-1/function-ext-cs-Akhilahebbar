using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
   public class UIReporter:IReporter
    {
        public void ReportData(string message)
        {
            Console.WriteLine($"UI Report:{message}");
        }
    }
}
