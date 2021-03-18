using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public  class BatteryBreachLevel
    {
        public readonly IReporter _reporter;
        public BatteryBreachLevel()
        {

        }
        public BatteryBreachLevel(IReporter reporter)
        {
            _reporter = reporter;
        }
        public  void CheckMinBreachLevel(float chargeLevel, float ActualValue, float minValue)
        {
            float chargeRate = chargeLevel + minValue;

            if (minValue <= ActualValue && ActualValue <= chargeRate)
            {
                Warnings.Discharge = Constants.LowDischarge;
                BatteryMessages.DisplayWarningMessage(Warnings.Discharge, _reporter);

            }
        }

        public  void CheckMaxBreachLevel(float chargeLevel, float actualValue, float maxValue)
        {
            float chargeRate = maxValue - chargeLevel;

            if (chargeRate <= actualValue && actualValue<= maxValue)
            {
                Warnings.ChargePeak = Constants.PeakDischarge;
                BatteryMessages.DisplayWarningMessage(Warnings.ChargePeak, _reporter);
            }
        }
    }
}
