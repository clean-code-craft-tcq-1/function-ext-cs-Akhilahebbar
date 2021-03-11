using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
   public static class BatteryMessages
    {
        public static bool isGerman = false;
        public static void DisplayBatteryStatus(string property, BatteryStates batteryLevel)
        {
            if (isGerman)
            {
                Console.WriteLine($"Batterie {property} ist {batteryLevel}");
                return;
            }
            Console.WriteLine($"Battery {property} is {batteryLevel}");
        }

        public static void DisplayWarningMessage(string warning)
        {
            if (isGerman)
            {
                Console.WriteLine($"{warning}");
                return;
            }

            Console.WriteLine($"{warning}");
        }
    }
}
