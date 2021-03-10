using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public static class BatteryBreachLevel
    {
        public static void CheckTemperatureThreshold(Battery battery)
        {
            if (battery.TempMin <= battery.temperature && battery.temperature <= battery.TempMin + battery.threshold)
            {
                BatteryMessages.DisplayWarnings("Temperature", Constants.LowDischarge);
            }

            if (battery.TempMax - battery.threshold <= battery.temperature && battery.temperature <= battery.TempMax)
            {
                BatteryMessages.DisplayWarnings("Temperature", Constants.PeakDischarge);
            }
        }
        public static void CheckSocThreshold(Battery battery)
        {
            if (battery.SocMin <= battery.StateCharge && battery.StateCharge <= battery.SocMin + battery.threshold)
            {
                BatteryMessages.DisplayWarnings("State Of Charge", Constants.LowDischarge);
            }

            if (battery.SocMax - battery.threshold <= battery.StateCharge && battery.StateCharge <= battery.SocMax)
            {
                BatteryMessages.DisplayWarnings("State Of Charge", Constants.PeakDischarge);
            }
        }
        public static void CheckChargeRateThreshold(Battery battery)
        {
            if (battery.ChargeRateMin <= battery.ChargeRate && battery.ChargeRate <= battery.ChargeRateMin + battery.threshold)
            {
                BatteryMessages.DisplayWarnings("Charge Rate", Constants.LowDischarge);
            }

            if (battery.ChargeRateMax - battery.threshold <= battery.ChargeRate && battery.ChargeRate <= battery.ChargeRateMax)
            {
                BatteryMessages.DisplayWarnings("Charge Rate", Constants.PeakDischarge);
            }
        }
    }
}
