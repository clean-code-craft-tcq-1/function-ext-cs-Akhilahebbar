using System;
using System.Diagnostics;
namespace BatteryManagement
{
class Checker
{
   
    static int Main() {
         TestBatteryStatus batterystatus = new TestBatteryStatus();


            batterystatus.CheckBatteryStatus(-1, 20, 0.3f);
            batterystatus.CheckBatteryStatus(1, 22, 0.4f);
            batterystatus.CheckBatteryStatus(100, 82, 0.1f);
            batterystatus.CheckBatteryStatus(1, 22, 0.4f);
          
            return 0;
    }
}
}
