using System;

namespace BatteryManagement
{
    public static class BatteryCondition
    {
      
        public static BatteryStates CheckBatteryCondition(float currentValue, float minValue, float maxValue)
        {
            if (CheckMaxCondition(currentValue, maxValue) == BatteryStates.High)
            {
                return BatteryStates.High;
            }

            if (CheckMinCondition(currentValue, minValue) == BatteryStates.Low)
            {
                return BatteryStates.Low;

            }

            return BatteryStates.Normal;
        }

        private static BatteryStates CheckMaxCondition(float actualValue, float maxValue)
        {
            if (actualValue > maxValue)
            {
                return BatteryStates.High;
            }
            return BatteryStates.Normal;
        }

        private static BatteryStates CheckMinCondition(float actualValue, float minValue)
        {
            if (actualValue < minValue)
            {
                return BatteryStates.Low;
            }
            return BatteryStates.Normal;
        }

    }
}
