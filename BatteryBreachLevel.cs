using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public static class BatteryBreachLevel
    {

        public static void CheckMinBreachLevel(float chargeLevel, float ActualValue, float minValue)
        {
            float chargeRate = chargeLevel + minValue;

            if (minValue <= ActualValue && ActualValue <= chargeRate)
            {
                Warnings.Discharge = Constants.LowDischarge;
                BatteryMessages.DisplayWarningMessage(Warnings.Discharge);
            }
        }

        public static void CheckMaxBreachLevel(float chargeLevel, float actualValue, float maxValue)
        {
            float chargeRate = maxValue - chargeLevel;

            if (chargeRate <= actualValue && actualValue<= maxValue)
            {
                Warnings.ChargePeak = Constants.PeakDischarge;
                BatteryMessages.DisplayWarningMessage(Warnings.ChargePeak);
            }
        }
    }
}
