using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
   public static class BatteryMessages
    {
        public static bool GermanLanguage = false;
        public static void DisplayStatus(string attribute, Constants.BatteryStates batteryCondition)
        {
            if (GermanLanguage)
            {
                Console.WriteLine($"Batterie {attribute} ist {batteryCondition}");
                return;
            }
            Console.WriteLine($"Battery {attribute} is {batteryCondition}");
        }
        public static void DisplayWarnings(string attribute, string warningMsg)
        {
            if (GermanLanguage)
            {
                Console.WriteLine($"Warnung-{attribute}: {warningMsg}");
                return;
            }
            Console.WriteLine($"Warning-{attribute}: {warningMsg}");
        }
    }
}
