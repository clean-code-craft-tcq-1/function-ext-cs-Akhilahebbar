using System;

namespace BatteryManagement
{
    internal class TestBatteryStatus
    {
    
        public static void CheckBatteryStatus(float temperature, float soc, float chargeRate)
        {
            BatteryCondition.CheckTemperature(temperature);
            BatteryCondition.CheckChargeState(soc);
            BatteryCondition.CheckChargeRate(chargeRate);
        }


       
    }
}
