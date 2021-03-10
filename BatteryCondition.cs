using System;

namespace BatteryManagement
{
    internal static class BatteryCondition
    {
        public static void CheckChargeRate(float chargeRate)
        {
            Battery battery = new Battery();
            float threshold = CalculateThreshold(chargeRate, Constants.maxTemperature);

            battery.threshold = threshold;
            battery.ChargeRateMin = Constants.minChargeRate;
            battery.ChargeRateMax = Constants.maxChargeRate;
            battery.ChargeRate = chargeRate;

            BatteryBreachLevel.CheckChargeRateThreshold(battery);
            Constants.BatteryStates batteryChargeRate = CheckBatteryCondition(chargeRate, Constants.minChargeRate, Constants.maxChargeRate);
            BatteryMessages.DisplayStatus("Charge Rate", batteryChargeRate);
        }

        public static void CheckChargeState(float soc)
        {
            Battery battery = new Battery();
            float threshold = CalculateThreshold(soc, Constants.maxStateOfCharge);

            battery.threshold = threshold;
            battery.SocMin = Constants.minStateOfCharge;
            battery.SocMax = Constants.maxStateOfCharge;
            battery.StateCharge = soc;

            BatteryBreachLevel.CheckSocThreshold(battery);
            Constants.BatteryStates batteryChargeState = CheckBatteryCondition(soc, Constants.minStateOfCharge, Constants.maxStateOfCharge);
            BatteryMessages.DisplayStatus("State Of Charge", batteryChargeState);
        }

        public static void CheckTemperature(float temperature)
        {
            Battery battery = new Battery();
            float threshold = CalculateThreshold(temperature, Constants.maxTemperature);

            battery.threshold = threshold;
            battery.ChargeRateMin = Constants.minTemperature;
            battery.ChargeRateMax = Constants.maxTemperature;
            battery.temperature = temperature;

            BatteryBreachLevel.CheckTemperatureThreshold(battery);
            Constants.BatteryStates batteryTemperature = CheckBatteryCondition(temperature, Constants.minTemperature, Constants.maxTemperature);
            BatteryMessages.DisplayStatus("Temperature", batteryTemperature);
        }
        public static Constants.BatteryStates CheckBatteryCondition(float actualValue, float minValue, float maxValue)
        {
            if (CheckMaxBatteryCondition(actualValue, maxValue) == Constants.BatteryStates.High)
            {
                return Constants.BatteryStates.High;
            }

            if (CheckMaxBatteryCondition(actualValue, minValue) == Constants.BatteryStates.Low)
            {
                return Constants.BatteryStates.Low;
            }

            return Constants.BatteryStates.Normal;
        }
        public static Constants.BatteryStates CheckMaxBatteryCondition(float actualValue, float maxValue)
        {
            if (actualValue > maxValue)
            {
                return Constants.BatteryStates.High;
            }
            return Constants.BatteryStates.Normal;
        }
        public static Constants.BatteryStates CheckMinBatteryCondition(float actualValue, float minValue)
        {
            if (actualValue < minValue)
            {
                return Constants.BatteryStates.Low;
            }
            return Constants.BatteryStates.Normal;
        }
        public static float CalculateThreshold(float actualValue, float thresholdPercent)
        {
            return thresholdPercent * actualValue / 100;
        }

    }
}
