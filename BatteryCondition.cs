using System;

namespace BatteryManagement
{
    public static class BatteryCondition
    {
      
      

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
