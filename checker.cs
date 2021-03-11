using System;
using System.Diagnostics;
namespace BatteryManagement
{
class Checker
{
   
    static int Main() {
       BatteryMessages.isGerman = true;

            TestBatteryStatus.CheckBatteryStatus(-1, 20, 0.3f);
            TestBatteryStatus.CheckBatteryStatus(1, 22, 0.4f);

            BatteryMessages.isGerman = false;

            TestBatteryStatus.CheckBatteryStatus(100, 82, 0.1f);
            TestBatteryStatus.CheckBatteryStatus(1, 22, 0.4f);
            return 0;
    }
}
}
